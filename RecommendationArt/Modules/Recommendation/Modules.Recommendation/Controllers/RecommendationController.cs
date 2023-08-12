using MediatR;
using Microsoft.AspNetCore.Mvc;
using Modules.Recommendation.Core.Dto;
using Modules.Recommendation.Core.Features.CreateRecommendation;
using Modules.Recommendation.Core.Features.DeleteRecommendation;
using Modules.Recommendation.Core.Features.GetAllRecommendations;
using Modules.Recommendation.Core.Features.GetRecommedationById;
using Modules.Recommendation.Core.Features.UpdateRecommendation;

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
        public async Task<IActionResult> GetRecommedationsAsync(CancellationToken cancellationToken)
        {
            var request = new GetAllRecommendationsRequest();

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response.Recommendations);
        }

        [HttpGet]
        [Route("/recommedations/{Id}")]
        public async Task<IActionResult> GetRecommedationByIdAsync(int Id, CancellationToken cancellationToken)
        {
            var request = new GetRecommedationByIdRequest { Id = Id };

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response.Recommendation);
        }

        [HttpPost]
        [Route("/recommedations")]
        public async Task<IActionResult> CreateRecommedationAsync([FromBody] CreateRecommendationDto recommendation, CancellationToken cancellationToken)
        {
            var request = new CreateRecommendationRequest
            {
                Title = recommendation.Title,
                CreatedDate = DateTime.Now,
                Description = recommendation.Description,
                JokeRating = recommendation.JokeRating,
                Occasion = recommendation.Occasion,
                Platform = recommendation.Platform,
                TrueRating = recommendation.TrueRating,
                Url = recommendation.Url,
                UserId = recommendation.UserId
            };

            var response = await _mediator.Send(request, cancellationToken);

            return Created(string.Empty, response.Recommendation);
        }

        [HttpPut]
        [Route("/recommedations/{Id}")]
        public async Task<IActionResult> UpdateRecommedationAsync(int Id, [FromBody] UpdateRecommendationDto recommendation, CancellationToken cancellationToken)
        {
            var request = new UpdateRecommendationRequest
            {
                Id = Id,
                Title = recommendation.Title,
                Description = recommendation.Description,
                JokeRating = recommendation.JokeRating,
                Occasion = recommendation.Occasion,
                Platform = recommendation.Platform,
                TrueRating = recommendation.TrueRating,
                Url = recommendation.Url,
                UserId = recommendation.UserId
            };

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response.Recommendation);
        }

        [HttpDelete]
        [Route("/recommedations/{Id}")]
        public async Task<IActionResult> DeleteRecommedationAsync(int Id, CancellationToken cancellationToken)
        {
            var request = new DeleteRecommendationRequest
            {
                Id = Id
            };

            await _mediator.Send(request, cancellationToken);

            return NoContent();
        }

        //TODO
        //agregar guards
    }
}