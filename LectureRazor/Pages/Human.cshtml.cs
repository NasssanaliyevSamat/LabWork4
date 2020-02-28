using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LectureRazor
{
    public class HumanModel : PageModel
    {
        public IActionResult OnGet()
        {
            int x = 10;
            if (x == 10)
            {
                return NotFound("You entered wrong URL");
            }
            else
            {
                return Page();
            }
        }
    }
}
