using Microsoft.AspNetCore.Mvc;

namespace Modules.Recommendation.Controllers
{
    [ApiController]
    [Route("/api/recommedations/[controller]")]
    public class RecommendationController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRecommedationsAsync()
        {
            return Ok();
        }
    }
}