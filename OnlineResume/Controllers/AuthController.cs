using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineResume.Data;
using OnlineResume.Models;
using System.Security.Claims;

namespace OnlineResume.Controllers
{
	public class AuthController : Controller
	{
		private readonly AppDBContext context;

		public AuthController(AppDBContext context)
		{
			this.context = context;
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost("/Auth/Login")]
		public async Task<IActionResult> Login(User user)
		{
			var theUser = context.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Email == user.Email && u.Password == user.Password);
			if (theUser == null)
			{
				return Redirect("/");
			}
			var claims = new List<Claim>() {
				new Claim(ClaimTypes.NameIdentifier,theUser.Id.ToString()),
				new Claim("username",theUser.UserName.ToString()),
				new Claim("email",theUser.Email.ToString()),
			};

			var identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

			var claimsPrincipal = new ClaimsPrincipal(identity);

			var httpHeaders = new AuthenticationProperties()
			{
				IsPersistent = true,
			};

			await HttpContext.SignInAsync(claimsPrincipal,httpHeaders);

			return Redirect("/Panel");
		}


		[HttpGet("/Auth/Logout")]
		[Authorize]
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return Redirect("/");
		}

	}
}
