using Domain.Interfaces;
using Entitites.Entities;
using Infra.Configuration;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
	public class FinancialSystemRepository : RepositoryGeneric<FinancialSystem>, IFinancialSystem
	{
		private readonly DbContextOptions<ContextBase> _dbContext;

		public FinancialSystemRepository()
		{
			_dbContext = new DbContextOptions<ContextBase>();
		}

		public async Task<IList<FinancialSystem>> ListFinancialSystem(string email)
		{
			using (var context = new ContextBase(_dbContext))
			{
				return await
				   (from f in context.FinancialSystems
					join uf in context.UserFinancialSystems on f.Id equals uf.IdSistema
					where uf.EmailUsuario.Equals(email)
					select f
					).AsNoTracking().ToListAsync();
			}
		}
	}
}
