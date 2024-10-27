using InfoSystem.Models;
using InfoSystem.Service;
using Microsoft.AspNetCore.Mvc;

namespace InfoSystem.Controllers
{
    public class EventController : Controller
    {

        private readonly IDriverRepository _driverRepo;
        private readonly IEventRepository _eventRepo;

        public EventController(IDriverRepository driverRepo, IEventRepository eventRepo)
        {
            _driverRepo = driverRepo;
            _eventRepo = eventRepo;
        }
        public IActionResult Create(int driverId)
        {
            var model = new Event
            {
                DriverID = driverId  
            };
            return View(model);
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event eventt)
        {
            if (ModelState.IsValid)
            {
                // Hämta föraren och uppdatera TotalBeloppUt
                var driver = await _driverRepo.GetByIdAsync(eventt.DriverID);
                if (driver != null)
                {
                    driver.TotalBeloppUt += eventt.BeloppUt; 
                    driver.TotalBeloppIn += eventt.BeloppIn;
                    await _driverRepo.UpdateAsync(driver); 
                }

                await _eventRepo.AddAsync(eventt); 
                await _eventRepo.SaveAsync(); 
                return RedirectToAction("Details", "Driver", new { id = eventt.DriverID });
            }
            return View(eventt);
        }


        public async Task<IActionResult> Notifications()
        {
            // Sätt intervallet beroende på användarroll
            TimeSpan interval = User.IsInRole("Admin") ? TimeSpan.FromHours(24) : TimeSpan.FromHours(12);

            // Hämta de senaste händelserna med rätt intervall
            var recentEvents = await _eventRepo.GetRecentEventsAsync(interval);

            // Returnera vy med de senaste händelserna
            return View(recentEvents);
        }
    }
}
