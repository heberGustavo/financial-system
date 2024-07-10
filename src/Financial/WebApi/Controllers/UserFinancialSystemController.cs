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
	public class UserFinancialSystemController : ControllerBase
	{
		private readonly IUserFinancialSystemService _userFinancialSystemService;

		public UserFinancialSystemController(IUserFinancialSystemService financialSystemService)
		{
			_userFinancialSystemService = financialSystemService;
		}

		[Produces("application/json")]
		[HttpGet("/api/ListUserSystem")]
		public async Task<object> ListUserSystem(int idSistema)
		{
			return await _userFinancialSystemService.ListUserSystem(idSistema);
		}

		[Produces("application/json")]
		[HttpPost("/api/CreateUserInSystem")]
		public async Task<object> CreateUserInSystem(int idSistema, string emailUsuario)
		{
			try
			{
				await _userFinancialSystemService.CreateUserInSystem(
				new UserFinancialSystem
				{
					IdSistema = idSistema,
					EmailUsuario = emailUsuario,
					Administrador = false,
					SistemaAtual = true
				});
			}
			catch (Exception)
			{
				return Task.FromResult(false);
			}
			return Task.FromResult(true);
		}

	}
}
