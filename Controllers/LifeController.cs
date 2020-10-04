using Microsoft.AspNetCore.Mvc;

namespace Game_of_Life_MVC.Controllers
{
	public class LifeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}