using KubeTestAPI.DBContext;
using KubeTestAPI.Entities;

namespace KubeTestAPI.Repositories
{
    public class WeatherRepository :IWeatherRepository
    {
        private readonly WeatherDBContext _context;

        public WeatherRepository(WeatherDBContext dbcontext)
        {
            _context = dbcontext;
        }

        public IEnumerable<Locations> GetLocations()
        {
            return _context.Locations.ToList();
        }

        public IEnumerable<Temperatures> GetTemperatures()
        {
            return _context.Temperatures.ToList();
        }
    }
}
