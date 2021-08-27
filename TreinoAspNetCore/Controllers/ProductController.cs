using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoAspNetCore.Repositories;
using TreinoAspNetCore.Services;

namespace TreinoAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductsRepository _productsRepository;
        private readonly ProductServices _productServices;
        public ProductController(ProductServices productServices)
        {
            _productServices = productServices;
        }
        [HttpPost("insert", Name = "CreatedProduct")]
        public async Task<IActionResult> InsertProducts()
        {
            var productList =  await _productServices.GetProductList();

            return Ok(productList);

        }
    }
}
