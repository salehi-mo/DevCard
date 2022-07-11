using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using DevCard_MVC.Data;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _Services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس"),
        };
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {
             
            var Project = ProjectsStore.GetProjectBy(id);
            return View(Project);
            
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_Services, "Id", "Name")
            };
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            //var name = form.Name;
            //return Json(Ok());
            model.Services = new SelectList(_Services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست.لطفا مجدد تلاش کنید";
                return View(model);
            }
            
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_Services, "Id", "Name")
            };
            ViewBag.Success = "اطلاعات شما با موفقیت ثبت گردید.";
            return View(model);


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
