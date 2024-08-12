using MediatR;
using Volxyseat.Api.Application.Models.ViewModels;

namespace Volxyseat.Api.Application.Queries
{
    public class GetSubscriptionQuery : IRequest<SubscriptionDto>
    {
        public Guid Id { get; set; }
    }

    public class GetAllSubscriptionQuery : IRequest<IEnumerable<SubscriptionDto>>
    {

    }
}
