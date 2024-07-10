using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entitites.Entities;

namespace Domain.Services
{
	public class CategoryService : ICategoriaService
	{
		private readonly ICategory _iCategoria;

		public CategoryService(ICategory iCategoria)
		{
			_iCategoria = iCategoria;
		}

		public async Task<IList<Category>> ListCategoryByUser(string email) => await _iCategoria.ListCategoryByUser(email);

		public async Task AddCategory(Category category)
		{
			var valid = category.ValidPropertyString(category.Nome, "Nome");
			if (valid)
				await _iCategoria.Add(category);
		}

		public async Task UpdateCategory(Category category)
		{
			var valid = category.ValidPropertyString(category.Nome, "Nome");
			if (valid)
				await _iCategoria.Update(category);
		}
	}
}
