using Domain.Interfaces.IServices;
using Entitites.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebApi.Models.DTO;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoriaService _categoryService;

		public CategoryController(ICategoriaService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("/api/ListCategoryByUser")]
		[Produces("application/json")]
		public async Task<object> ListCategoryByUser(string email)
		{
			return await _categoryService.ListCategoryByUser(email);
		}

		[HttpPost("/api/AddCategory")]
		[Produces("application/json")]
		public async Task<object> AddCategory(CategoryDTO category)
		{
			await _categoryService.AddCategory(MapperToEntity(category));
			return category;
		}

		[HttpPut("/api/UpdateCategory")]
		[Produces("application/json")]
		public async Task<object> UpdateCategory(CategoryDTO category)
		{
			await _categoryService.UpdateCategory(MapperToEntity(category));
			return category;
		}

		#region Private Methods

		private Category MapperToEntity(CategoryDTO category)
		{
			return new Category
			{
				Id = category.Id,
				Nome = category.Nome,
				IdSistema = category.IdSistema
			};
		}

		#endregion
	}
}
