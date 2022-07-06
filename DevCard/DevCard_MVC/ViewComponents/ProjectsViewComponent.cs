using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی اینترنتی", "project-1.jpg", "snap"),
                new Project(2, "زود فود", "درخواست آنلاین غذا", "project-2.jpg", "zoodfood"),
                new Project(3, "مدارس", "آموزش جامع مجازی", "project-3.jpg", "Ibm"),
                new Project(4, "فضاپیما", "مدیریت فضا پیماهای ناسا", "project-4.jpg", "Nasa"),
                
            };
            return View("_Projects",Projects);

        }
    }
}
