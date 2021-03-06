using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlazorMivies.Shared
{
    public class WeatherForecast
    {
        [DisplayName("Date")]
        public DateTime Date { get; set; }

        [DisplayName("Temp.(C)")]
        public int TemperatureC { get; set; }

        [DisplayName("Temp.(F)")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [DisplayName("Summary")]
        public string Summary { get; set; }
    }
}
