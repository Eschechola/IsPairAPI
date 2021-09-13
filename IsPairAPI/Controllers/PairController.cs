using IsPairAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace IsPairAPI.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PairController : ControllerBase
    {
        private readonly IPairService _pairService;

        public PairController(IPairService pairService)
        {
            _pairService = pairService;
        }

        [HttpGet]
        [Route("is-pair")]
        public IActionResult IsPair(decimal number){
            if(_pairService.IsPair(number))
                return Ok(string.Format("The {0} number is pair!", number));
            
            return BadRequest(string.Format("The {0} number is odd!", number));
        }
    }
}