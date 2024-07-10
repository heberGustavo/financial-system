using Entitites.Entities;

namespace Domain.Interfaces.IServices
{
	public interface IFinancialSystemService
	{
		Task AddFinancialSystem(FinancialSystem financialSystem);
		Task UpdateFinancialSystem(FinancialSystem financialSystem);
		Task<IList<FinancialSystem>> ListFinancialSystem(string email);
	}
}
