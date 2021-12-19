using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using Portfolio.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Pages.Blog
{
    public class PostModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Post Post;

        private ISanityClient SanityClient;

        private ISanityImgHelper SanityImgHelper;


        public PostModel(ILogger<IndexModel> logger, ISanityClient sanityClient, ISanityImgHelper sanityImgHelper)
        {
            _logger = logger;
            SanityClient = sanityClient;
            SanityImgHelper = sanityImgHelper;
        }
        public async Task<PageResult> OnGetAsync(string slug)
        {
            //Console.WriteLine(slug);
            await GetPost(slug);
            return Page();
        }

        private async Task<Post> GetPost(string slug)
        {
            var post = await SanityClient.GetPost(slug);

            var imgRef = post.MainImage.Asset.Ref;
            post.ImgUrl = SanityImgHelper.GetImageUrl(imgRef, 500,null);

            Post = post;



            return post;
            
        }

        public async Task<string> ContentToHtml(IEnumerable<PostBody> postBody)
        {
            var html = await SanityClient.BuildHtml(postBody);
            return html;

        }
    }
}
