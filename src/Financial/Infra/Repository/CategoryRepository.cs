using Domain.Interfaces;
using Entitites.Entities;
using Infra.Configuration;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
	public class CategoryRepository : RepositoryGeneric<Category>, ICategory
	{
		private readonly DbContextOptions<ContextBase> _dbContext;

        public CategoryRepository()
        {
            _dbContext = new DbContextOptions<ContextBase>();
        }

        public async Task<IList<Category>> ListCategoryByUser(string email)
		{
			using (var context = new ContextBase(_dbContext))
			{
				 return await 
					(from f in context.FinancialSystems
					 join c in context.Categories on f.Id equals c.IdSistema
					 join uf in context.UserFinancialSystems on f.Id equals uf.IdSistema
					 where uf.EmailUsuario.Equals(email) && uf.SistemaAtual
					 select c
					 ).AsNoTracking().ToListAsync();
			}
		}
	}
}
