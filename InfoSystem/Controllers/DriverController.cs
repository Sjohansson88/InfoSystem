using InfoSystem.Models;
using InfoSystem.Service;
using Microsoft.AspNetCore.Mvc;

namespace InfoSystem.Controllers
{
	public class DriverController : Controller
	{

		private readonly IDriverRepository _driverRepo;
        private readonly IEventRepository _eventRepo;

		public DriverController(IDriverRepository driverRepo, IEventRepository eventRepo)
		{
			_driverRepo = driverRepo;
            _eventRepo = eventRepo;
		}

        public async Task<IActionResult> Index()
        {
            var drivers = await _driverRepo.GetAllAsync();
            return View(drivers);
        }




        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Driver driver)
        {
            if (ModelState.IsValid)
            {
                await _driverRepo.AddAsync(driver);

               
                var createEvent = new Event
                {
                    DriverID = driver.DriverID,
                    NoteDescription = "Driver created",
                    NoteDate = DateTime.Now,
                    ActionType = "Create"  
                };
                await _eventRepo.AddAsync(createEvent);

                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var driver = await _driverRepo.GetByIdAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Driver updatedDriver)
        {
            if (id != updatedDriver.DriverID) return NotFound();

            if (ModelState.IsValid)
            {
                await _driverRepo.UpdateAsync(updatedDriver);

                var editEvent = new Event
                {
                    DriverID = updatedDriver.DriverID,
                    NoteDescription = "Driver updated",
                    NoteDate = DateTime.Now,
                    ActionType = "Edit"  
                };
                await _eventRepo.AddAsync(editEvent);

                return RedirectToAction(nameof(Index));
            }
            return View(updatedDriver);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var driver = await _driverRepo.GetByIdAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _driverRepo.DeleteAsync(id);
            await _driverRepo.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id, DateTime? startDate, DateTime? endDate)
        {
            var driver = await _driverRepo.GetByIdAsync(id);

            if (driver == null)
            {
                return NotFound();
            }

           
            var driverWithEvents = await _driverRepo.GetDriverWithEventsAsync(id);

           
            if (startDate.HasValue && endDate.HasValue)
            {
                driverWithEvents.Events = driverWithEvents.Events
                    .Where(e => e.NoteDate >= startDate.Value && e.NoteDate <= endDate.Value)
                    .ToList();
            }

            return View(driverWithEvents);
        }



        public async Task<IActionResult> Search(string searchString)
        {
            var drivers = await _driverRepo.GetAllAsync();

            ViewData["SearchString"] = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                drivers = drivers.Where(d => d.DriverName.Contains(searchString)).ToList();
            }
            else
            {
                drivers = new List<Driver>(); 
            }

            return View(drivers);
        }

    }
}
