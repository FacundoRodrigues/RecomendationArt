using MediatR;
using Microsoft.AspNetCore.Mvc;
using Modules.Recommendation.Core.Features.GetAllRecommendations;

namespace Modules.Recommendation.Controllers
{
    [Route("")]
    public class RecommendationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecommendationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/recommedations")]
        public async Task<IActionResult> GetRecommedationsAsync()
        {
            var request = new GetAllRecommendationsRequest();

            var response = await _mediator.Send(request);

            return Ok(response.Recommendations);
        }

        [HttpPost]
        [Route("/recommedations")]
        public async Task<IActionResult> CreateRecommedationAsync()
        {
            var request = new GetAllRecommendationsRequest();

            var response = await _mediator.Send(request);

            return Ok(response.Recommendations);
        }
    }
}