using Domain.Interfaces;
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
	public class FinancialSystemController : ControllerBase
	{
		private readonly IFinancialSystemService _financialSystemService;

		public FinancialSystemController(IFinancialSystemService financialSystemService)
		{
			_financialSystemService = financialSystemService;
		}

		[Produces("application/json")]
		[HttpGet("/api/ListFinancialSytem")]
		public async Task<object> ListFinancialSytem(string email)
		{
			return await _financialSystemService.ListFinancialSystem(email);
		}

		[Produces("application/json")]
		[HttpPost("/api/AddFinancialSystem")]
		public async Task<object> AddFinancialSystem(FinancialSystemDTO financialSystem)
		{
			await _financialSystemService.AddFinancialSystem(MapperToEntity(financialSystem));
			return Task.FromResult(financialSystem);
		}

		[Produces("application/json")]
		[HttpPut("/api/UpdateFinancialSystem")]
		public async Task<object> UpdateFinancialSystem(FinancialSystemDTO financialSystem)
		{
			await _financialSystemService.UpdateFinancialSystem(MapperToEntity(financialSystem));
			return Task.FromResult(financialSystem);
		}

		#region Private Methods

		private FinancialSystem MapperToEntity(FinancialSystemDTO financialSystem)
		{
			return new FinancialSystem
			{
				Id = financialSystem.Id,
				Nome = financialSystem.Nome,
				Mes = financialSystem.Mes,
				Ano = financialSystem.Ano,
				DiaFechamento = financialSystem.DiaFechamento,
				GerarCopiaDespesa = financialSystem.GerarCopiaDespesa,
				MesCopia = financialSystem.MesCopia,
				AnoCopia = financialSystem.AnoCopia,
			};
		}

		#endregion
	}
}
