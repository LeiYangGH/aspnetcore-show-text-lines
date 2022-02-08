using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
namespace WebTextLines.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IWebHostEnvironment _hostEnvironment;
        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment _hostEnvironment)
        {
            _logger = logger;
            this._hostEnvironment = _hostEnvironment;
        }

        public string[] Lines { get; set; }

        public void OnGet()
        {
            // you need change the fullName, and may need some exception handling
            string fullName = Path.Combine(_hostEnvironment.WebRootPath, "js/site.js");
            Lines = System.IO.File.ReadAllLines(fullName);
        }
    }
}