﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishTank.ViewModels
{
    public class DashboardViewModel
    {
        public SensorTileViewModel WaterTemperatureTile { get; set; }
        public SensorTileViewModel FishMotionTile { get; set; }
        public SensorTileViewModel WaterOpacityTile { get; set; }
        public SensorTileViewModel LightIntensityTile { get; set; }
        [Display(Name= "Please enter food amount:")]
        public int FoodAmount { get; set; }
        [Display(Name = "Last feeding was at:")]
        public string LastFed { get; set; }
    }
}
