using Domain.Interfaces.IServices;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Helpers.DependencyGroups
{
	public class ServiceDependencyInjection
	{
		public static void Register(IServiceCollection services)
		{
			services.AddSingleton<ICategoriaService, CategoryService>();
			services.AddSingleton<IExpenseService, ExpenseService>();
			services.AddSingleton<IFinancialSystemService, FinancialSystemService>();
			services.AddSingleton<IUserFinancialSystemService, UserFinancialSystemService>();
		}
	}
}
