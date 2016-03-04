using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using FishTank.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FishTank.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult GetWaterTemperatureChart()
        {
            return View("Chart", new ChartControllerViewModel
            {
                Title = "Water Temperature",
                DataUrl = Url.Action("GetWaterTemperatureHistory", "HistoryData")
            });
        }


        public IActionResult GetFishMotionChart()
        {
            return View("Chart", new ChartControllerViewModel
            {
                Title = "Fish Motion",
                DataUrl = Url.Action("GetFishMotionPercentageHistory", "HistoryData")
            });
        }

        public IActionResult GetWaterOpacityChart()
        {
            return View("Chart", new ChartControllerViewModel
            {
                Title = "Water Opacity",
                DataUrl = Url.Action("GetWaterOpacityPercentageHistory", "HistoryData")
            });
        }

        public IActionResult GetLightIntensityChart()
        {
            return View("Chart", new ChartControllerViewModel
            {
                Title = "Light Intensity",
                DataUrl = Url.Action("GetLightIntensityLumensHistory", "HistoryData")
            });
        }
    }
}
