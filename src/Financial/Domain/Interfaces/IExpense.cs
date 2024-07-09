using Domain.Interfaces.Generics;
using Entitites.Entities;

namespace Domain.Interfaces
{
    public interface IExpense : IGeneric<Expense>
    {
        Task<IList<Expense>> ListExpenseUser(string email);
    }
}
