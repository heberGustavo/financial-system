using Entitites.Entities;

namespace Domain.Interfaces.IServices
{
	public interface ICategoriaService
	{
		Task AddCategory(Category category);
		Task UpdateCategory(Category category);
	}
}
