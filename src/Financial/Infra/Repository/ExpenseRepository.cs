using Domain.Interfaces;
using Entitites.Entities;
using Infra.Configuration;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
	public class ExpenseRepository : RepositoryGeneric<Expense>, IExpense
	{
		private readonly DbContextOptions<ContextBase> _dbContext;

		public ExpenseRepository()
		{
			_dbContext = new DbContextOptions<ContextBase>();
		}

		public async Task<IList<Expense>> ListExpenseUser(string email)
		{
			using (var context = new ContextBase(_dbContext))
			{
				return await
				   (from f in context.FinancialSystems
					join c in context.Categories on f.Id equals c.IdSistema
					join uf in context.UserFinancialSystems on f.Id equals uf.IdSistema
					join e in context.Expenses on c.Id equals e.IdCategoria
					where uf.EmailUsuario.Equals(email) && f.Mes == e.Mes && f.Ano == e.Ano
					select e
					).AsNoTracking().ToListAsync();
			}
		}
	}
}
