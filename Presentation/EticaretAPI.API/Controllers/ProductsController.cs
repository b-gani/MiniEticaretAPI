using EticaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EticaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new(){ Id=Guid.NewGuid(),Name="Product 1", Price=100, CreatedDate=DateTime.UtcNow, Stock=10 },
            //    new(){ Id=Guid.NewGuid(),Name="Product 2", Price=200, CreatedDate=DateTime.UtcNow, Stock=20 },
            //    new(){ Id=Guid.NewGuid(),Name="Product 3", Price=300, CreatedDate=DateTime.UtcNow, Stock=30 },
            //    new(){ Id=Guid.NewGuid(),Name="Product 4", Price=400, CreatedDate=DateTime.UtcNow, Stock=40 },
            //});
            //await _productWriteRepository.SaveAsync();

            var p = await _productReadRepository.GetByIdAsync("3a2d70e8-401d-4e8d-a127-46c167615e66",false);
            p.Name = "Mehmet";
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}