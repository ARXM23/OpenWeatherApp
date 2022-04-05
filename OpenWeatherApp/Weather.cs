﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp
{
    public class WeatherCont
    {
        public class coordenates
        {
            public double longitude { get; set; }
            public double latitude { get; set; }
        }
        public class weather 
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class main
        {
            public double temp { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }
        public class wind
        {
            public double speed { get; set; }
        }
        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }
        public class root
        {
            public coordenates coordenates { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
    
}
    
