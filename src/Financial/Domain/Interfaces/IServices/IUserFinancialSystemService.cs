using Entitites.Entities;

namespace Domain.Interfaces.IServices
{
	public interface IUserFinancialSystemService
	{

		Task<UserFinancialSystem> GetUserByEmail(string email);
		Task<IList<UserFinancialSystem>> ListUserSystem(int idSistema);

		Task CreateUserInSystem(UserFinancialSystem userFinancialSystem);
		Task RemoveUsersSystem(List<UserFinancialSystem> users);
	}
}
