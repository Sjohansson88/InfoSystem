using InfoSystem.Data;
using InfoSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem.Service
{
	public class DriverRepository : Repository<Driver>, IDriverRepository
	{

		private readonly AppDbContext _context;

        public DriverRepository(AppDbContext context) : base(context) 
		{
			_context = context;
		}

        public async Task<Driver> GetDriverWithEventsAsync(int id)
        {
            return await _context.Drivers
			.Include(d => d.Events) 
			.FirstOrDefaultAsync(d => d.DriverID == id);
        }

     

        public async Task<List<Driver>> GetRecentDriversAsync(TimeSpan interval)
        {
            var recentTime = DateTime.Now - interval;
            return await _context.Drivers
                .Where(d => d.NoteDate >= recentTime)
                .ToListAsync();
        }

        public async Task<IEnumerable<Driver>> SearchDriversAsync(string DriverName)
		{
			return await _context.Drivers
		   .Where(d => d.DriverName.Contains(DriverName) || d.CarReg.Contains(DriverName))
		   .ToListAsync();
		}


	}
}
