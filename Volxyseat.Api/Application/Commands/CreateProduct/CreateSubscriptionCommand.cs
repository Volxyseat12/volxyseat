using MediatR;
using Volxyseat.Domain.Models;

namespace Volxyseat.Api.Application.Commands.CreateSubscription
{
    public record class CreateSubscriptionCommand(
        SubscriptionEnum TypeId,
        SubscriptionStatus StatusId,
        string Description,
        double Price,
        DateTime CreatedOn,
        DateTime UpdatedOn) : IRequest<bool>
    {

    }
}
