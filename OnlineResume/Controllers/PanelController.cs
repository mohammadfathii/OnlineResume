using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineResume.Controllers
{
	[Authorize]
	public class PanelController : Controller
	{
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
	}
}
