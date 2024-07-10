using Domain.Interfaces.IServices;
using Entitites.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.DTO;

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
		public async Task<object> AddExpense(ExpenseDTO expense)
		{
			await _expenseService.AddExpense(MapperToEntity(expense));
			return expense;
		}

		[HttpPut("/api/UpdateExpense")]
		[Produces("application/json")]
		public async Task<object> UpdateExpense(ExpenseDTO expense)
		{
			await _expenseService.UpdateExpense(MapperToEntity(expense));
			return expense;
		}

		#region Private Methods

		private Expense MapperToEntity(ExpenseDTO dto)
		{
			return new Expense
			{
				Id = dto.Id,
				Nome = dto.Nome,
				Valor = dto.Valor,
				Mes = dto.Mes,
				Ano = dto.Ano,
				TipoDespesa = dto.TipoDespesa,
				DataCadastro = dto.DataCadastro,
				DataAlteracao = dto.DataAlteracao,
				DataPagamento = dto.DataPagamento,
				DataVencimento = dto.DataVencimento,
				Pago = dto.Pago,
				DespesaAtrasada = dto.DespesaAtrasada,
				IdCategoria = dto.IdCategoria,
			};
		}

		#endregion
	}
}
