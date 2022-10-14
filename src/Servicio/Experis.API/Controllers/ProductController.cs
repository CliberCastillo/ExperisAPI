using Experis.Application.DTO;
using Experis.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Experis.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        [HttpGet]
        public ProductDTO Get()
        {
            return _productAppService.GetById(1);
        }
    }
}