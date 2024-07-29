using ECommerceApi.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public TestController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id=Guid.NewGuid() , Name ="Product 1",Createdate=DateTime.UtcNow,Price=100,Stock=100},
                new() {Id=Guid.NewGuid() , Name ="Product 2",Createdate=DateTime.UtcNow,Price=200,Stock=50},
                new() {Id=Guid.NewGuid() , Name ="Product 3",Createdate=DateTime.UtcNow,Price=1300,Stock=10}
            });
            await _productWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
