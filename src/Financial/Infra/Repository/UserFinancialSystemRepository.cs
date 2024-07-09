using Domain.Interfaces;
using Entitites.Entities;
using Infra.Configuration;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
	public class UserFinancialSystemRepository : RepositoryGeneric<UserFinancialSystem>, IUserFinancialSystem
	{
		private readonly DbContextOptions<ContextBase> _dbContext;

		public UserFinancialSystemRepository()
		{
			_dbContext = new DbContextOptions<ContextBase>();
		}

		public async Task<UserFinancialSystem> GetUserByEmail(string email)
		{
			using (var context = new ContextBase(_dbContext))
			{
				return await
					context.UserFinancialSystems.AsNoTracking()
					.FirstOrDefaultAsync(x => x.EmailUsuario.Equals(email));
			}
		}

		public async Task<IList<UserFinancialSystem>> ListUserSystem(int idSistema)
		{
			using (var context = new ContextBase(_dbContext))
			{
				return await
					context.UserFinancialSystems
					.Where(u => u.IdSistema == idSistema)
					.AsNoTracking().ToListAsync();
			}
		}

		public async Task RemoveUsersSystem(List<UserFinancialSystem> users)
		{
			using (var context = new ContextBase(_dbContext))
			{
				context.UserFinancialSystems.RemoveRange(users);
				await context.SaveChangesAsync();
			}
		}
	}
}
