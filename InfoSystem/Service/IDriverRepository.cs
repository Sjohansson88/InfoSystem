using InfoSystem.Models;

namespace InfoSystem.Service
{
	public interface IDriverRepository : IRepository<Driver>
	{
		Task<IEnumerable<Driver>> SearchDriversAsync(string DriverName);
        Task<Driver> GetDriverWithEventsAsync(int id);
        Task<List<Driver>> GetRecentDriversAsync(TimeSpan interval);
    }
}
