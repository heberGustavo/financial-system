using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Infra.Repository;
using Infra.Repository.Generics;
using Microsoft.Extensions.DependencyInjection;

namespace Helpers.DependencyGroups
{
	public class RepositoryDependencyInjection
	{
		public static void Register(IServiceCollection services)
		{
			services.AddSingleton(typeof(IGeneric<>), typeof(RepositoryGeneric<>));

			services.AddSingleton<ICategory, CategoryRepository>();
			services.AddSingleton<IExpense, ExpenseRepository>();
			services.AddSingleton<IFinancialSystem, FinancialSystemRepository>();
			services.AddSingleton<IUserFinancialSystem, UserFinancialSystemRepository>();
		}
	}
}
