using Domain.Interfaces.IServices;
using Entitites.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
		public async Task<object> AddCategory(Category category)
		{
			await _categoryService.AddCategory(category);
			return category;
		}

		[HttpPut("/api/UpdateCategory")]
		[Produces("application/json")]
		public async Task<object> UpdateCategory(Category category)
		{
			await _categoryService.UpdateCategory(category);
			return category;
		}
	}
}
