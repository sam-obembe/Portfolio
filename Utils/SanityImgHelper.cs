using Microsoft.Extensions.Configuration;
using System.Text;

namespace Portfolio.Utils
{
    public class SanityImgHelper:ISanityImgHelper
    {
        private string ProjectId;
        private IConfiguration Configuration;
        public SanityImgHelper(IConfiguration configuration)
        {
            Configuration = configuration;

            var sanityId = Configuration.GetSection("SanityId").Value;
            ProjectId = sanityId;

        }

        public string GetImageUrl(string imageRef,int? height = null, int? width = null)
        {
            var baseUri = "https://cdn.sanity.io/images/"+ProjectId+"/production/";
            var refRebuild = imageRef.Replace("image-", "");
            var lastHyphen = refRebuild.LastIndexOf("-");

            var sb = new StringBuilder(refRebuild);
            
            if(lastHyphen > 0)
            {
                sb[lastHyphen] = '.';
            }

            if(height != null)
            {
                sb.Append("?h=" + height.ToString());
            }

            if(width != null)
            {
                sb.Append("&w=" + width.ToString());
            }

            return baseUri + sb.ToString();
        }
    }
}
