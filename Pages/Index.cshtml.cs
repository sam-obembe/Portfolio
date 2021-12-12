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

        private ISanityClient SanityClient;

        public IndexModel(ILogger<IndexModel> logger, ISanityClient sanityClient)
        {
            _logger = logger;
            SanityClient = sanityClient;
            
        }

        public async Task<IActionResult> OnGetAsync()
        {

           await GetSkills();

            return Page();
            

        }

        private async Task<IEnumerable<Skill>> GetSkills()
        {
            var skills = await SanityClient.GetSkills();
            Skills = skills;

            return skills;
        }
    }
}
