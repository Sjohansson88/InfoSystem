using InfoSystem.Service;
using Microsoft.AspNetCore.Mvc;

namespace InfoSystem.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IEventRepository _eventRepo;
        private readonly IDriverRepository _driverRepo;


        public NotificationsController(IEventRepository eventRepo, IDriverRepository driverRepo)
        {
            _eventRepo = eventRepo;
            _driverRepo = driverRepo;
        }
        public async Task<IActionResult> Index()
        {
            
            TimeSpan interval = User.IsInRole("Admin") ? TimeSpan.FromHours(24) : TimeSpan.FromHours(12);

            var recentEvents = await _eventRepo.GetRecentEventsAsync(interval);
            var recentDrivers = await _driverRepo.GetRecentDriversAsync(interval);

            bool hasNotifications = recentEvents.Any();
            ViewBag.HasNotifications = hasNotifications;
            ViewBag.RecentDrivers = recentDrivers;
            return View(recentEvents);
        }

        [HttpGet]
        public async Task<bool> HasNotifications()
        {
            
            TimeSpan interval = User.IsInRole("Admin") ? TimeSpan.FromHours(24) : TimeSpan.FromHours(12);

            var recentEvents = await _eventRepo.GetRecentEventsAsync(interval);
            return recentEvents.Any();
        }


    }
}
