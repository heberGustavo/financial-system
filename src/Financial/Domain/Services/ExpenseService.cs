using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entitites.Entities;

namespace Domain.Services
{
	public class ExpenseService : IExpenseService
	{
		private readonly IExpense _iExpense;

		public ExpenseService(IExpense iExpense)
		{
			_iExpense = iExpense;
		}

		public async Task AddExpense(Expense expense)
		{
			var data = DateTime.Now;
			expense.DataCadastro = data;
			expense.Ano = data.Year;
			expense.Mes = data.Month;

			var valid = expense.ValidPropertyString(expense.Nome, "Nome");
			if (valid)
				await _iExpense.Add(expense);
		}

		public async Task UpdateExpense(Expense expense)
		{
			var data = DateTime.Now;
			expense.DataAlteracao = data;

			if (expense.Pago)
				expense.DataPagamento = data;

			var valid = expense.ValidPropertyString(expense.Nome, "Nome");
			if (valid)
				await _iExpense.Update(expense);
		}
	}
}
