using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using Portfolio.Utils;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Skill> Skills;

        public AboutMe AboutMe;

        private ISanityClient SanityClient;

        public IndexModel(ILogger<IndexModel> logger, ISanityClient sanityClient)
        {
            _logger = logger;
            SanityClient = sanityClient;
            
        }

        public async Task<IActionResult> OnGetAsync()
        {

           await GetSkills();
            await GetAboutMe();

            return Page();
            

        }

        private async Task GetSkills()
        {
            var skills = await SanityClient.GetSkills();
            Skills = skills;

            //return skills;
        }

        private async Task GetAboutMe()
        {
            var aboutMe = await SanityClient.GetAboutMe();
            AboutMe = aboutMe;
        }

        public async Task<string> ContentToHtml(AboutMe aboutMe)
        {
            var html = await SanityClient.BuildHtml(aboutMe.Body);
            return html;
        }
    }

}
