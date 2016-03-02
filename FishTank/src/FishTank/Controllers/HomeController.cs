using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using FishTank.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FishTank.Controllers
{
    public class HomeController : Controller
    {
        private IViewModelService viewModelService;

        public HomeController(IViewModelService viewModelService)
        {
            this.viewModelService = viewModelService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Fish tank dashboard";
            return View(viewModelService.GetDashboardViewModel()

                );
        }

        public IActionResult Feed(int foodAmount)
        {
            var model = viewModelService.GetDashboardViewModel();
            model.LastFed = $"{DateTime.Now.Hour}:{ DateTime.Now.Minute }:{ DateTime.Now.Second}. Amount: { foodAmount} ";
            return View("Index", model);
        }
    }
}
