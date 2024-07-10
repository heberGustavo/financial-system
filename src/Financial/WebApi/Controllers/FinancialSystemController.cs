using Domain.Interfaces;
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
		public async Task<object> AddFinancialSystem(FinancialSystem financialSystem)
		{
			await _financialSystemService.AddFinancialSystem(financialSystem);
			return Task.FromResult(financialSystem);
		}

		[Produces("application/json")]
		[HttpPut("/api/UpdateFinancialSystem")]
		public async Task<object> UpdateFinancialSystem(FinancialSystem financialSystem)
		{
			await _financialSystemService.UpdateFinancialSystem(financialSystem);
			return Task.FromResult(financialSystem);
		}

	}
}
