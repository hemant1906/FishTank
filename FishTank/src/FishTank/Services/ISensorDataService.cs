using FishTank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTank.Services
{
    public interface ISensorDataService
    {
        IntHistoryModel GetWaterTemperature();
        IEnumerable<IntHistoryModel> GetWaterTemperatureHistory();
        IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory();
        IntHistoryModel GetWaterOpacityPercentage();
        IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory();
        IntHistoryModel GetLightIntensityLumens();
        IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory();
        IntHistoryModel GetFishMotionPercentage();
    }
}
