using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ViewData.Models;
using ViewData.Repository;

namespace ViewData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IDemo _iDemo;
     

        public HomeController(ILogger<HomeController> logger,IWebHostEnvironment webHostEnvironment , IDemo iDemo)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _iDemo = iDemo; 

        }

        public IActionResult Index()
        {
            _iDemo.GetGuard();
            var model = new HomeModel
            {
                Name = "Lokesh",
                Age = 20
            };
            ViewBag.Message = "This is a message for viewbag";
            ViewData["Messages"] = "This is message for Viewdata";
            TempData["Messagess"] = "This is message for tempdata";
            return View(model);
        }
        public IActionResult RedirectToAnotherAction()
        {
            TempData["Log"] = "This Messisge for Redirection";
            return RedirectToAction("Error", "Home");
        }

        public IActionResult GetJsonData()
        {
            var data = new { Name = "Lokesh", Age = 30 };
            return Json(data);
        }

		public IActionResult PlainText()
		{
			return Content("This is plain text","application/json");
		}

        public IActionResult DownloadFile()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Example.txt");

            if(System.IO.File.Exists(filePath))
            {
                return PhysicalFile(filePath, "application/pdf", "Example.txt");
            }
            else
            {
                return NotFound();  
            }
        }
		public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult ShowPartial()
        {
            return PartialView("_TestPartial"); ;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
