using KubeTestAPI.Entities;

namespace KubeTestAPI.Repositories
{
    public interface IWeatherRepository
    {
        IEnumerable<Locations> GetLocations();
        IEnumerable<Temperatures> GetTemperatures();

    }
}
