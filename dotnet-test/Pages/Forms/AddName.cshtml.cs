using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet_test
{
    public class NameModel : PageModel
    {

        [BindProperty]
        public Models.NameModel YourName { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/Index", new { FirstName = YourName.FirstName, LastName = YourName.LastName });
        }
    }
}
