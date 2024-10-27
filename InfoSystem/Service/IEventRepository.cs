using InfoSystem.Models;

namespace InfoSystem.Service
{
	public interface IEventRepository : IRepository<Event>
	{
		Task<IEnumerable<Event>> GetEventsByDriverAsync(int driverId);
		Task<IEnumerable<Event>> GetEventsByDateRangeAsync(int driverId, DateTime startDate, DateTime endDate);
        Task<int> GetNotificationCountAsync();
        Task<IEnumerable<Event>> GetRecentEventsAsync(TimeSpan interval);
		

	}
}
