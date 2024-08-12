using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volxyseat.Domain.Repositories;

namespace Volxyseat.Api.Application.Queries
{
    public class GetAllSubscriptionsHandlerIRequestHandler<GetAllSubscriptionsQuery, SubscriptionDto>
    {
        private readonly IVolxyseatRepository _repository;

        public GetAllSubscriptionsHandlerIRequestHandler(IVolxyseatRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IEnumerable<SubscriptionDto>> Handle(GetAllSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var subscriptions = _repository.GetAll();

            var query = subscriptions.AsQueryable();

            var data = query.AsNoTracking().Select(item => new
            {
                item.Id,
                item._typeId,
                item._statusId,
                item.Description,
                item.Price,
                item.CreatedOn,
                item.UpdatedOn
            });


            return (IEnumerable<SubscriptionDto>)data;

        }
    }
}