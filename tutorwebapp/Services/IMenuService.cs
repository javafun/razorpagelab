using System.Collections.Generic;
using tutorwebapp.Pages;

namespace tutorwebapp.Services
{
    interface IMenuService
    {
        List<MenuItem> GetMenuItems();

        List<MenuItem> GetPopularItems();
    }
}