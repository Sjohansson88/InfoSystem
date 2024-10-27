using InfoSystem.Data;
using InfoSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem.Service
{
	public class EventRepository : Repository<Event>, IEventRepository
	{

		private readonly AppDbContext _context;

		public EventRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

    

        public async Task<IEnumerable<Event>> GetEventsByDateRangeAsync(int driverId, DateTime startDate, DateTime endDate)
		{
			return await _context.Events
		  .Where(e => e.DriverID == driverId && e.NoteDate >= startDate && e.NoteDate <= endDate)
		  .ToListAsync();
		}

		public async Task<IEnumerable<Event>> GetEventsByDriverAsync(int driverId)
		{
			return await _context.Events
		   .Where(e => e.DriverID == driverId)
		   .ToListAsync();
		}

        public async Task<int> GetNotificationCountAsync()
        {
            var twelveHoursAgo = DateTime.Now.AddHours(-12);
            return await _context.Events
                .CountAsync(e => e.NoteDate >= twelveHoursAgo);
        }

     

        public async Task<IEnumerable<Event>> GetRecentEventsAsync(TimeSpan interval)
        {
            var recentTime = DateTime.Now - interval;
            return await _context.Events
                .Include(e => e.Driver)
                .Where(e => e.NoteDate >= recentTime)
                .ToListAsync();
        }
    }
}
