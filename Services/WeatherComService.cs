using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WeatherComService : IWeatherService
    {
        public decimal GetTemperature(string yer)
        {
            yer = yer.ToLower();

            switch (yer)
            {
                case "ankara":
                    return 33m;
                case "istanbul":
                    return 34m;
                case "adana":
                    return 38m;
                case "tokyo":
                    return 26m;
                default:
                    return new Random().Next(5, 35);
            }
        }

        public decimal Temperature(string place)
        {
            return GetTemperature(place);
        }
    }
}