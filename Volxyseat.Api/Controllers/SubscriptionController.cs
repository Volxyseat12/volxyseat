using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Volxyseat.Api.Application.Commands.CreateSubscription;
using Volxyseat.Api.Application.Commands.CreateUser;
using Volxyseat.Api.Application.Models.Request;
using Volxyseat.Api.Application.Models.ViewModels;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetSubscriptionQuery(id);

            var result = await _mediator.Send(query);

            return Ok(result);
        }


        [HttpGet]
        [ProducesResponseType(typeof(SubscriptionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllSubscriptionQuery();
            var person = await _mediator.Send(query);
            return person != null ? Ok(person) : NotFound();
        }

        [HttpPost("/new-subscription")]
        [ProducesResponseType(typeof(SubscriptionViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public async Task<IActionResult> Post([FromBody] CreateSubscriptionCommand request)
        {
            var result = await _mediator.Send(request);
            return result ? Ok() : BadRequest();
        }

        [HttpPost("/new-user")]
        [ProducesResponseType(typeof(UserViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand request)
        {
            var result = await _mediator.Send(request);
            return result ? Ok() : BadRequest();
        }
    }
}