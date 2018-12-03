using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tutorwebapp.Services;

namespace tutorwebapp
{
    public class PopularBrews : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var menuService = new MenuService();
            return View(menuService.GetPopularItems().Take(count));
        }
    }
}