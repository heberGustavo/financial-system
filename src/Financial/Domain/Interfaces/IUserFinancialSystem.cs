using Domain.Interfaces.Generics;
using Entitites.Entities;

namespace Domain.Interfaces
{
    public interface IUserFinancialSystem : IGeneric<UserFinancialSystem>
    {
        Task<UserFinancialSystem> GetUserByEmail(string email);
        Task<IList<UserFinancialSystem>> ListUserSystem(int idSistema);
        Task RemoveUsersSystem(List<UserFinancialSystem> users);
    }
}
