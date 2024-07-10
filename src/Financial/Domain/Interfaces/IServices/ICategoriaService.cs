using Entitites.Entities;

namespace Domain.Interfaces.IServices
{
	public interface ICategoriaService
	{
		Task<IList<Category>> ListCategoryByUser(string email);
		Task<IList<Category>> GetAllCategories();
		Task AddCategory(Category category);
		Task UpdateCategory(Category category);
	}
}
