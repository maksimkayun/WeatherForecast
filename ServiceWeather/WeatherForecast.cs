using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceWeather
{
    
    [Table("weather_forecasts")]
    public class WeatherForecast
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("date")]
        public DateTime Date { get; set; }

        [Column("temperature_c")]
        public int TemperatureC { get; set; }
        
        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        [Column("summary")]
        public string Summary { get; set; }
    }
}