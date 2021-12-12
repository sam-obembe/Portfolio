using Microsoft.Extensions.Configuration;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Sanity.Linq;
using System.Web;
using Sanity.Linq.BlockContent;

namespace Portfolio.Utils
{
    public class SanityApiClient:ISanityClient
    {
        private IConfiguration Configuration;
        private string ApiUrl;
        private SanityDataContext SanityDataContext;
        private SanityOptions SanityOptions;
        public SanityApiClient(IConfiguration configuration)
        {
            Configuration = configuration;

            var sanityId = Configuration.GetSection("SanityId").Value;
            var apiUrl = Configuration.GetSection("SanityApiUrl").Value;
            var token = Configuration.GetSection("SanityApiToken").Value;

            ApiUrl = apiUrl.Replace("{{sanityId}}", sanityId).Replace("{{version}}", DateTime.UtcNow.ToString("yyyy-MM-dd"));

            SanityOptions =  new SanityOptions
            {
                ProjectId = sanityId,
                Dataset = "production",
                Token = token,
                UseCdn = false,
                ApiVersion = "v1"
            };

            SanityDataContext = new SanityDataContext(SanityOptions);
        }

        private HttpClient GetClient()
        {
            return new HttpClient();
        }

        public async Task<IEnumerable<Skill>> GetSkills()
        {
            var skillDocumentSet = SanityDataContext.DocumentSet<Skill>();
            var skills = await skillDocumentSet.ToListAsync();
            return skills;
        }


        public async Task<IEnumerable<Post>> GetPosts()
        {
            var postQuery = "*[_type == 'post']{title,_createdAt,slug,mainImage}";
            var requestUri = ApiUrl + postQuery;
            var vanillaPostQuery = await GetClient().GetAsync(requestUri);

            var resultString = await vanillaPostQuery.Content.ReadAsStringAsync();

            var postResult = JsonSerializer.Deserialize<GetPostsResponse>(resultString);

            return postResult.Result;
            /*var postDocumentSet = SanityDataContext.DocumentSet<Post>(10);

            var posts = await postDocumentSet.ToListAsync();

            return posts;*/
            
            //throw new NotImplementedException();
        }


        public async Task<Post> GetPost(string slug)
        {
            var postQuery = $"*[_type == 'post' {HttpUtility.UrlEncode("&&")} slug.current == '{slug}']";
            //var encodedQuery = HttpUtility.UrlEncode(postQuery);
            var requestUri = ApiUrl + postQuery;

            var vanillaPostQuery = await GetClient().GetAsync(requestUri);

            var resultString = await vanillaPostQuery.Content.ReadAsStringAsync();

            var postResult = JsonSerializer.Deserialize<GetPostsResponse>(resultString);

            return postResult.Result.FirstOrDefault();

            
        }

        public async Task<string> BuildHtml(IEnumerable<PostBody> postBody)
        {
            var builder = new SanityHtmlBuilder(SanityOptions);
            try
            {
                var postBodyJson = JsonSerializer.Serialize<IEnumerable<PostBody>>(postBody);
                var html = await builder.BuildAsync(postBodyJson);

                //Console.WriteLine(html);

                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            
        }
       
    }
}
