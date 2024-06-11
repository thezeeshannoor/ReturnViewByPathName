using Microsoft.AspNetCore.Mvc;
using ReturnViewUsingPathName.Models;
using System.Diagnostics;

namespace ReturnViewUsingPathName.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public string Page(string file)
		{
			return $"~/Views/{file}";
		}
		public IActionResult Indexx()
		{
			return View(Page("Index.cshtml"));
		}

		
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
