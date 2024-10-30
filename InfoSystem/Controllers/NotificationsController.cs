using InfoSystem.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InfoSystem.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IEventRepository _eventRepo;
        private readonly IDriverRepository _driverRepo;
        private readonly IEmployeeRepository _employeeRepo;


        public NotificationsController(IEventRepository eventRepo, IDriverRepository driverRepo, IEmployeeRepository employeeRepo)
        {
            _eventRepo = eventRepo;
            _driverRepo = driverRepo;
            _employeeRepo = employeeRepo;
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


        
        public async Task<IActionResult> Count()
        {
            ViewBag.EventCount = await _eventRepo.GetCountAsync();
            ViewBag.DriverCount = await _driverRepo.GetCountAsync();
            ViewBag.EmployeeCount = await _employeeRepo.GetCountAsync();

            return View();
        }


    }
}
