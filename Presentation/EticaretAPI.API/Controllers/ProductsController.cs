using EticaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EticaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        

        public ProductsController()
        {
             
        }

        [HttpGet]
        public Task Get()
        {
            throw new NotImplementedException();
            
        }

    }
}