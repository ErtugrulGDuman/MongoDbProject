using Microsoft.AspNetCore.Mvc;
using MongoDbProject.Dtos.ProductDtos;
using MongoDbProject.Services.ProductSevices;

namespace MongoDbProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return View();
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDtos createProductDtos)
        {
            await _productService.CreateProductAsync(createProductDtos);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var value = await _productService.GetByIdProductAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDtos updateProductDtos)
        {
            await _productService.UpdateProductAsync(updateProductDtos);
            return RedirectToAction("ProductList");
        }
    }
}
