using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public AboutModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
