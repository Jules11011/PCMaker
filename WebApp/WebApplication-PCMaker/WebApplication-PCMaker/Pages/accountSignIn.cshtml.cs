using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PCMaker___Logic_layer;

namespace WebApplication_PCMaker.Pages
{
    public class accountSignInModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public Account newAccount { get; set; }
    }
}
