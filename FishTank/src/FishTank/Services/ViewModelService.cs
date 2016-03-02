using FishTank.ViewModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTank.Services
{
    public class ViewModelService : IViewModelService
    {
        private ISensorDataService sensorDataService;
        private IUrlHelper urlHelper;

        public ViewModelService(ISensorDataService sensorDataService, IUrlHelper urlHelper)
        {
            this.sensorDataService = sensorDataService;
            this.urlHelper = urlHelper;
        }

        public DashboardViewModel GetDashboardViewModel()
        {

            return new DashboardViewModel
            {
                WaterTemperatureTile = new SensorTileViewModel
                {
                    Title = "Water temperature",
                    Value = sensorDataService.GetWaterTemperature().Value,
                    ColorCssClass = "panel-primary",
                    IconCssClass = "fa-sliders",
                    Url = urlHelper.Action("GetWaterTemperatureChart", "History")
                },
                FishMotionTile = new SensorTileViewModel
                {
                    Title = "Fish Motion",
                    Value = sensorDataService.GetFishMotionPercentage().Value,
                    ColorCssClass = "panel-success",
                    IconCssClass = "fa-plug",
                    Url = urlHelper.Action("GetFishMotionChart", "History")
                },
                LightIntensityTile = new SensorTileViewModel
                {
                    Title = "Light Intensity",
                    Value = sensorDataService.GetLightIntensityLumens().Value,
                    ColorCssClass = "panel-info",
                    IconCssClass = "fa-binoculars",
                    Url = urlHelper.Action("GetLightIntensityChart", "History")
                },
                WaterOpacityTile = new SensorTileViewModel
                {
                    Title = "Water Opacity",
                    Value = sensorDataService.GetWaterOpacityPercentage().Value,
                    ColorCssClass = "panel-danger",
                    IconCssClass = "fa-linux",
                    Url = urlHelper.Action("GetWaterOpacityChart", "History")
                }
            };
        }
    }
}
