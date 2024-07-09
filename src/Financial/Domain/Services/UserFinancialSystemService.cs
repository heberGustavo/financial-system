using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entitites.Entities;

namespace Domain.Services
{
	public class UserFinancialSystemService : IUserFinancialSystemService
	{
		private readonly IUserFinancialSystem _financialSystem;

		public UserFinancialSystemService(IUserFinancialSystem financialSystem)
		{
			_financialSystem = financialSystem;
		}

		public async Task CreateUserInSystem(UserFinancialSystem userFinancialSystem)
		{
			await _financialSystem.Add(userFinancialSystem);
		}
	}
}
