using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.CLI
{
    internal class WeatherResponse
    {
        public Weather Main { get; set; }
        public Forecast Sys { get; set; }
        public string Name { get; set; }

    }
}
