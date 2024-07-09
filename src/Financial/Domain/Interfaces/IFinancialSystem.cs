using Domain.Interfaces.Generics;
using Entitites.Entities;

namespace Domain.Interfaces
{
    public interface IFinancialSystem : IGeneric<FinancialSystem>
    {
        Task<IList<FinancialSystem>> ListFinancialSystem(string email);
	}
}
