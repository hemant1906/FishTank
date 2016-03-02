using FishTank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTank.Services
{
    public class SensorDataService : ISensorDataService
    {
        private readonly Random random = new Random();
        private IEnumerable<IntHistoryModel> waterTemperatureHistory;
        private IEnumerable<IntHistoryModel> fishMotionHistory;
        private IEnumerable<IntHistoryModel> waterOpacityHistory;
        private IEnumerable<IntHistoryModel> lightOpacityHistory;

        public IntHistoryModel GetWaterTemperature()
        {
            return GetWaterTemperatureHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetWaterTemperatureHistory()
        {
            return waterTemperatureHistory ?? (waterTemperatureHistory = GetHistory(30, 39));

        }

        private IEnumerable<IntHistoryModel> GetHistory(int min, int max)
        {
            List<IntHistoryModel> history = new List<IntHistoryModel>();

            for (int i = 15; i > 0; i--)
            {
                history.Add(new IntHistoryModel(  DateTime.Now.AddHours((double)-i) , random.Next(min, max) ));
            }
            return history;
        }




        public IntHistoryModel GetFishMotionPercentage()
        {
            return GetFishMotionPercentageHistory().Last();
        }


        public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
        {
            return fishMotionHistory ?? (fishMotionHistory = GetHistory(20, 40));
        }

        public IntHistoryModel GetWaterOpacityPercentage()
        {
            return GetWaterOpacityPercentageHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
        {
            return waterOpacityHistory ?? (waterOpacityHistory = GetHistory(60, 95));
        }

        public IntHistoryModel GetLightIntensityLumens()
        {
            return GetLightIntensityLumensHistory().Last();
        }

        public IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory()
        {
            return lightOpacityHistory ?? (lightOpacityHistory = GetHistory(120, 200));
        }
    }
}
