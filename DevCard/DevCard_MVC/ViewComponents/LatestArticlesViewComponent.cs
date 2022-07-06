using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var LatestArticles = new List<Article>
            {
                new Article(1, "آموزش جاوا", "blog-post-thumb-card-1.jpg", "آموزش کامل دوره جاوا از مبتدی تا پیشرفته"),
                new Article(2, "آموزش گیت هاب", "blog-post-thumb-card-2.jpg", "آموزش گیت و گیت هاب به همراه پروژه عملی"),
                new Article(3, "آموزش Asp.net core", "blog-post-thumb-card-3.jpg", "آموزش به همراه ساخت سایت آموزش"),
                new Article(4, "آموزش css", "blog-post-thumb-card-4.jpg", "آموزش به همراه مثال عملی"),
            };
            return View("_LatestArticles",LatestArticles);
        }
    }
}
