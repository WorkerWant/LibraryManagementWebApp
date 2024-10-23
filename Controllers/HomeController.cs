using LibraryManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryManagementWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

        public IActionResult Show()
        {
            var svgPath = Path.Combine(_env.WebRootPath, "images", "UMLDiagram.svg");

            if (!System.IO.File.Exists(svgPath)) 
				return NotFound("SVG file not found.");

            var svgContent = System.IO.File.ReadAllText(svgPath);
            ViewData["SvgContent"] = svgContent;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
