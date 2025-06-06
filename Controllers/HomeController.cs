using System.Diagnostics;
using E_CommerceProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceProject.Controllers
{
    //[Authorize(Roles = RoleViewModel.RoleUser)]
    //[Authorize(Roles = RoleViewModel.RoleAdmin)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly database db;
        private readonly IUnitofWork work;

        public HomeController(ILogger<HomeController> logger,database db,IUnitofWork work)
        {
            _logger = logger;
            this.db = db;
            this.work = work;
        }

        public async Task<IActionResult> Index(string? searth)
        {
            

            return View(await work.ProductRepo.GetAllAsync());
        }

        public IActionResult Searth(string searth)
        {
            
            return View();
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
