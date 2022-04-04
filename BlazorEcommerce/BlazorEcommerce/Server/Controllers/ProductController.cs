﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
          

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()      
        {          
            return Ok(await _productService.GetProductsAsync());          
        }

        [HttpGet("{productId}")]       
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            return Ok(await _productService.GetProductAsync(productId));
        }

        [HttpGet("{category/{categoryUrl}}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }


    }
}
