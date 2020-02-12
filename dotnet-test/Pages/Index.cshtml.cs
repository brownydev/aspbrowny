using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dotnet_test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                FirstName = "User";
            }
        }
    }
}
