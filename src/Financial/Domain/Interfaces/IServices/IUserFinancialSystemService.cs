using Entitites.Entities;

namespace Domain.Interfaces.IServices
{
	public interface IUserFinancialSystemService
	{
		Task CreateUserInSystem(UserFinancialSystem userFinancialSystem);
	}
}
