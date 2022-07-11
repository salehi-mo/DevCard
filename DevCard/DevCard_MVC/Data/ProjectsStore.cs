using DevCard_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DevCard_MVC.Data
{
    public class ProjectsStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی اینترنتی", "project-1.jpg", "snap"),
                new Project(2, "زود فود", "درخواست آنلاین غذا", "project-2.jpg", "zoodfood"),
                new Project(3, "مدارس", "آموزش جامع مجازی", "project-3.jpg", "Ibm"),
                new Project(4, "فضاپیما", "مدیریت فضا پیماهای ناسا", "project-4.jpg", "Nasa"),

            };
        }
        public static Project GetProjectBy(long id)
        {
            return GetProjects().SingleOrDefault(x => x.Id == id);
        }
    }
}
