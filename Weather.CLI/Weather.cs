using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.CLI
{
    internal class Weather
    {
        public float Temp { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
        public float Humidity { get; set; }
    }
    internal class Forecast
    {
        public float State { get; set; }
        public string Country { get; set; }
        public float Date { get; set; }
    }
}
