using Domain.Interfaces.Generics;
using Entitites.Entities;

namespace Domain.Interfaces
{
    public interface ICategory : IGeneric<Category>
    {
        Task<IList<Category>> ListCategoryByUser(string email);
    }
}
