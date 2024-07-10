using Entitites.Entities;

namespace Domain.Interfaces.IServices
{
	public interface IExpenseService
	{
		Task<IList<Expense>> ListExpenseUser(string email);
		Task AddExpense(Expense expense);
		Task UpdateExpense(Expense expense);
	}
}
