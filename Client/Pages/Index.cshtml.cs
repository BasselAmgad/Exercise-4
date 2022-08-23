using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Client.Pages
{
    public class IndexModel : PageModel
    {
        public string Url;

        public IndexModel(IConfiguration configuration)
        {
            Url = configuration["Url"];
        }

        public void OnGet()
        {

        }
    }
}