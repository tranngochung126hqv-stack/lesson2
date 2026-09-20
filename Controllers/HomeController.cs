using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return Content("Welcome to ASP.NET MVC");
		}

		public IActionResult About()
		{
			return Content("Sinh viên: Nguyễn Văn Thuận");
		}

		public IActionResult Contact()
		{
			return Content("Email: nguyenvanthuan@gmail.com");
		}
	}
}