using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Utils
{
    public interface ISanityClient
    {
        public Task<IEnumerable<Skill>> GetSkills();
        public Task<IEnumerable<Post>> GetPosts();

        public Task<Post> GetPost(string slug);

        public Task<string> BuildHtml(IEnumerable<PostBody> postBody);

        public Task<AboutMe> GetAboutMe();
    
    }
}
