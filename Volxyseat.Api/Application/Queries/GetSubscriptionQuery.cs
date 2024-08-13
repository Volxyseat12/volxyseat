using MediatR;
using Volxyseat.Api.Application.Models.ViewModels;

namespace Volxyseat.Api.Application.Queries
{
    public record GetSubscriptionQuery(Guid Id) : IRequest<SubscriptionDto>;

    public record GetAllSubscriptionQuery : IRequest<IEnumerable<SubscriptionDto>>;
}
