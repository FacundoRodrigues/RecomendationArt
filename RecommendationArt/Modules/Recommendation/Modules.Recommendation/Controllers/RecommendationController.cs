using Microsoft.AspNetCore.Mvc;

namespace Modules.Recommendation.Controllers
{
    [ApiController]
    [Route("/api/recommedations/[controller]")]
    internal class RecommendationController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRecommedationsAsync()
        {
            return Ok();
        }
    }
}