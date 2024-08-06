using MediatR;
using Volxyseat.Api.Application.Models.ViewModels;
using Volxyseat.Domain.Repositories;

namespace Volxyseat.Api.Application.Queries
{
    public class GetSubscriptionQueryHandler : IRequestHandler<GetSubscriptionQuery, SubscriptionDto>
    {
        private readonly IVolxyseatRepository _repository;

        public GetSubscriptionQueryHandler(IVolxyseatRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<SubscriptionDto> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var subscription = await _repository.GetByIdAsync(request.Id);

            if (subscription == null) return null;

            return new SubscriptionDto
            {
                Id = subscription.Id,
                Description = subscription.Description,
                Price = subscription.Price,
                CreatedOn = subscription.CreatedOn,
                UpdatedOn = subscription.UpdatedOn
            };
        }
    }
}
