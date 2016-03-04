using FishTank.Services;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.OptionsModel;
using FishTank.Options;

namespace FishTank.ViewComponents
{
    public class AlertViewComponent : ViewComponent
    {
        private ISensorDataService sensorDataService;
        private IOptions<ThresholdOptions> thresholdConfig;

        public AlertViewComponent(ISensorDataService sensorDataService
      ,      IOptions<ThresholdOptions> thresholdConfig)
        {
            this.sensorDataService = sensorDataService;
            this.thresholdConfig = thresholdConfig;
        }

        public IViewComponentResult Invoke()
        {
            var viewModel = new List<string>();
            if (sensorDataService.GetFishMotionPercentage().Value > thresholdConfig.Value.FishMotionMax)
                viewModel.Add("Too much fish activity");
            if (sensorDataService.GetFishMotionPercentage().Value < thresholdConfig.Value.FishMotionMin)
                viewModel.Add("Looks like some dead fishes");

            if (sensorDataService.GetLightIntensityLumens().Value > thresholdConfig.Value.LightIntensityMax)
                viewModel.Add("It is too bright out there");
            if (sensorDataService.GetLightIntensityLumens().Value < thresholdConfig.Value.LightIntensityMin)
                viewModel.Add("Its too dark");

            if (sensorDataService.GetWaterOpacityPercentage().Value > thresholdConfig.Value.WaterOpacityMax)
                viewModel.Add("Fish can't see you");
            if (sensorDataService.GetWaterOpacityPercentage().Value < thresholdConfig.Value.WaterOpacityMin)
                viewModel.Add("Water too clean");

            if (sensorDataService.GetWaterTemperature().Value > thresholdConfig.Value.WaterTemperatureMax)
                viewModel.Add("It's too hot for Fishes");
            if (sensorDataService.GetWaterTemperature().Value < thresholdConfig.Value.WaterTemperatureMin)
                viewModel.Add("It's too cold for Fishes");

            return View(viewModel);


        }
    }
}
