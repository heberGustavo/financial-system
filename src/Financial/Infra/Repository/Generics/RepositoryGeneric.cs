using Domain.Interfaces.Generics;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Infra.Repository.Generics
{
	public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
	{
		private readonly DbContextOptions<ContextBase> _dbContext;

        public RepositoryGeneric()
        {
            _dbContext = new DbContextOptions<ContextBase>();
        }

        public async Task Add(T entity)
		{
			using (var context = new ContextBase(_dbContext))
			{
				await context.Set<T>().AddAsync(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task Update(T entity)
		{
			using (var context = new ContextBase(_dbContext))
			{
				context.Set<T>().Update(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task Delete(T entity)
		{
			using (var context = new ContextBase(_dbContext))
			{
				context.Set<T>().Remove(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task<List<T>> GetAll()
		{
			using (var context = new ContextBase(_dbContext))
			{
				return await context.Set<T>().ToListAsync();
			}
		}

		public async Task<T> GetById(int id)
		{
			using (var context = new ContextBase(_dbContext))
			{
				return await context.Set<T>().FindAsync(id);
			}
		}

		#region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
		
		// Flag: Has Dispose already been called?
		bool disposed = false;
		// Instantiate a SafeHandle instance.
		SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

		// Public implementation of Dispose pattern callable by consumers.
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Protected implementation of Dispose pattern.
		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
				return;

			if (disposing)
			{
				handle.Dispose();
				// Free any other managed objects here.
				//
			}

			disposed = true;
		}

		#endregion
	}
}
