using InfoSystem.Data;
using InfoSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem.Service
{
    public class EmployeeRepository : IRepository<Employee>, IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Employee entity)
        {
            await _dbContext.Employees.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _dbContext.Employees.FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee entity)
        {
            _dbContext.Employees.Update(entity);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<int> GetCountAsync()
        {
            return await _dbContext.Employees.CountAsync();
        }
    }
}
