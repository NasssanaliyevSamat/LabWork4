using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LectureRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string type;        
        public string Pwd { get; set; }
        [BindProperty] 
        public Person p1 { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Message"] = RouteData.Values["name"] + " " + RouteData.Values["lname"];
        }

        public void OnPostLogin(string emaill, string pwdl)
        {
            ViewData["Message"] = emaill + " " + pwdl;
        }

        public IActionResult OnPostRegister()
        {
            int x = 10;
            if (x == 10)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
