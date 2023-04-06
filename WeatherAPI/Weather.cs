using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    public class Weather
    {
        public Temperature Main { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; }

    }

    public class Temperature
    {
        public double Temp { get; set; }
        public double Feels_like { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }


}
