using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tutorwebapp.Services;

namespace tutorwebapp.Pages
{
    public class ItemModel : PageModel
    {
        public MenuItem Item { get; private set; }

        public void OnGet(int id)
        {
            var menuService = new MenuService();

            Item = menuService.GetMenuItems().FirstOrDefault(x=>x.Id == id);
        }

    }
}