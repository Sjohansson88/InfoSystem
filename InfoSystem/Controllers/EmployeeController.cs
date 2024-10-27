using InfoSystem.Models;
using InfoSystem.Service;
using Microsoft.AspNetCore.Mvc;

namespace InfoSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var employees = await _employeeRepository.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e =>
                    e.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                    e.Email.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }

            return View(employees);
        }



        public async Task<IActionResult> Details(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeRepository.AddAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

       
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _employeeRepository.UpdateAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

       
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _employeeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
