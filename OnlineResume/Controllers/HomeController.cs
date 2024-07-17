using Microsoft.AspNetCore.Mvc;
using OnlineResume.Data;
using OnlineResume.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace OnlineResume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext context;

        public HomeController(ILogger<HomeController> logger,AppDBContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var personalData = context
                .PersonalData
                    .Include(p => p.Educations)
                    .Include(p => p.Experiences)
                    .Include(p => p.Languages)
                    .Include(p => p.Projects)
                    .Include(p => p.Skills)
                    .Include(p => p.SoftSkills)
                .FirstOrDefault(p => p.Id == 1);

            return View(personalData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
