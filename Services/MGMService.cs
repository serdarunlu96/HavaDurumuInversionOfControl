using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MGMService : IWeatherService
    {
        public decimal HavaSicakliginiGetir(string yer)
        {
            yer = yer.ToLower();

            switch (yer)
            {
                case "ankara":
                    return 30.8m;
                case "istanbul":
                    return 32.7m;
                case "adana":
                    return 35.1m;
                default:
                    return new Random().Next(1,40);
            }
        }

        public decimal Temperature(string place)
        {
            return HavaSicakliginiGetir(place);
        }
    }
}
