﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategoriesAsync());
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<ServiceResponse<Category>>> GetCategory(int categoryId)
        {
            return Ok(await _categoryService.GetCategoryAsync(categoryId));
        }
    }
}
