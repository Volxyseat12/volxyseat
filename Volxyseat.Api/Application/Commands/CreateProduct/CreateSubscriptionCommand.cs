using MediatR;
using Volxyseat.Api.Application.Models.ViewModels;
using Volxyseat.Domain.Models;

namespace Volxyseat.Api.Application.Commands.CreateSubscription
{
    public class CreateSubscriptionCommand : IRequest<bool>
    {
        public SubscriptionDto Subscription { get; set; }
        public SubscriptionEnum TypeId { get; set; }
        public SubscriptionStatus StatusId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public CreateSubscriptionCommand()
        {
            Subscription = new SubscriptionDto();
        }
    }
}
