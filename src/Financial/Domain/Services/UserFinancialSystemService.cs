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

		public async Task CreateUserInSystem(UserFinancialSystem userFinancialSystem) => await _financialSystem.Add(userFinancialSystem);

		public async Task<UserFinancialSystem> GetUserByEmail(string email) => await _financialSystem.GetUserByEmail(email);

		public async Task<IList<UserFinancialSystem>> ListUserSystem(int idSistema) => await _financialSystem.ListUserSystem(idSistema);

		public async Task RemoveUsersSystem(List<UserFinancialSystem> users) => await _financialSystem.RemoveUsersSystem(users);
	}
}
