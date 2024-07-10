using Domain.Interfaces.IServices;
using Entitites.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class ExpenseController : ControllerBase
	{
		private readonly IExpenseService _expenseService;

		public ExpenseController(IExpenseService expenseService)
		{
			_expenseService = expenseService;
		}

		[HttpGet("/api/ListExpenseUser")]
		[Produces("application/json")]
		public async Task<object> ListExpenseUser(string email)
		{
			return await _expenseService.ListExpenseUser(email);
		}

		[HttpPost("/api/AddExpense")]
		[Produces("application/json")]
		public async Task<object> AddExpense(Expense expense)
		{
			await _expenseService.AddExpense(expense);
			return expense;
		}

		[HttpPut("/api/UpdateExpense")]
		[Produces("application/json")]
		public async Task<object> UpdateExpense(Expense expense)
		{
			await _expenseService.UpdateExpense(expense);
			return expense;
		}
	}
}
