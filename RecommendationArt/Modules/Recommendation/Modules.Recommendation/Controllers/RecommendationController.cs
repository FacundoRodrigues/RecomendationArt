using MediatR;
using Microsoft.AspNetCore.Mvc;
using Modules.Recommendation.Core.Dto;
using Modules.Recommendation.Core.Features.CreateRecommendation;
using Modules.Recommendation.Core.Features.GetAllRecommendations;
using Modules.Recommendation.Core.Features.GetRecommedationById;

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

            throw new Exception();

            return Ok(response.Recommendations);
        }

        [HttpGet]
        [Route("/recommedations/{Id}")]
        public async Task<IActionResult> GetRecommedationByIdAsync(int Id)
        {
            var request = new GetRecommedationByIdRequest { Id = Id };

            var response = await _mediator.Send(request);

            return Ok(response.Recommendation);
        }

        [HttpPost]
        [Route("/recommedations")]
        public async Task<IActionResult> CreateRecommedationAsync([FromBody] CreateRecommendationDto recommendation)
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

            var response = await _mediator.Send(request);

            return Ok(response.Recommendation);
        }

        //TODO
        //1- agregar edicion
        //2- agregar guards
    }
}