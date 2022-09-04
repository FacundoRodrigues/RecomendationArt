using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Recommendation.Controllers
{
    [ApiController]
    [Route("/api/catalog/[controller]")]
    internal class RecommendationController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok();
        }
    }
}
