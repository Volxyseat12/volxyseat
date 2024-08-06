using MediatR;
using Microsoft.AspNetCore.Mvc;
using Volxyseat.Api.Application.Commands.CreateSubscription;
using Volxyseat.Api.Application.Queries;

namespace Volxyseat.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SubscriptionController : Controller
    {
        private readonly IMediator _mediator;

        public SubscriptionController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetSubscriptionQuery query)
        {
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
