using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tutorwebapp.Services;

namespace tutorwebapp.Pages
{
    public class ItemModel : PageModel
    {
        public MenuItem Item { get; private set; }

        public void OnGet(string slug)
        {
            var menuService = new MenuService();

            Item = menuService.GetMenuItems().FirstOrDefault(x=>x.Slug == slug);
        }

    }
}