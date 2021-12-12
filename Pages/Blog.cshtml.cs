using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using Portfolio.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Portfolio.Pages
{
    public class BlogModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Post> Posts;

        private ISanityClient SanityClient;

        private ISanityImgHelper SanityImgHelper;


        public BlogModel(ILogger<IndexModel> logger, ISanityClient sanityClient, ISanityImgHelper sanityImgHelper)
        {
            _logger = logger;
            SanityClient = sanityClient;
            SanityImgHelper = sanityImgHelper;

        }
        public async Task<PageResult> OnGetAsync()
        {
            await GetPosts();

            return Page();
        }


        private async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await SanityClient.GetPosts();

            foreach(var post in posts)
            {
                if (post.MainImage.Asset.Ref != null)
                {
                    var imgRef = post.MainImage.Asset.Ref;
                    post.ImgUrl = SanityImgHelper.GetImageUrl(imgRef,100,100);
                }
                
            }

            Posts = posts;
            return posts;
        }

        
    }
}
