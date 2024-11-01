﻿
using InfoSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem.Service
{
	public class Repository<T> : IRepository<T> where T : class
	{

		private readonly AppDbContext _context;
		private readonly DbSet<T> _dbSet;

		public Repository(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			var entity = await _dbSet.FindAsync(id);
			if (entity != null)
			{
				_dbSet.Remove(entity);
			}
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync(); 
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

        public async Task<int> GetCountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task SaveAsync()
		{
			await _context.SaveChangesAsync();
		}

		public Task UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
			return Task.CompletedTask;
		}
	}
}
