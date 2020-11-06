using System;

namespace ReproNSwagJsonPatchDocumentNRE.Features.Weather
{
    public class UpdateWeatherForecast
    {
        public DateTime? Date { get; set; }

        public int? TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
