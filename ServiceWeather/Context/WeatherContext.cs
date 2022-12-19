using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ServiceWeather.Context
{
    public partial class WeatherContext : DbContext
    {
        public WeatherContext() : base()
        {
        }

        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }
        
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }
        
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        // }
        //
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        // }
        //
        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}