using KubeTestAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace KubeTestAPI.DBContext
{
    public class WeatherDBContext :DbContext
    {
        public WeatherDBContext(DbContextOptions<WeatherDBContext> options) : base(options)
        {
        }

        public DbSet<Locations> Locations { get; set; }
        public DbSet<Temperatures> Temperatures { get; set; }
        public DbSet<Temperatures> Test { get; set; }
    }
}
