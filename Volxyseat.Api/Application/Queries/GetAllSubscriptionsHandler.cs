using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Volxyseat.Api.Application.Models.ViewModels;
using Volxyseat.Domain.Repositories;

namespace Volxyseat.Api.Application.Queries
{
    public class GetAllSubscriptionsHandlerIRequestHandler : IRequestHandler<GetAllSubscriptionQuery, IEnumerable<SubscriptionDto>>
    {
        private readonly IVolxyseatRepository _repository;

        public GetAllSubscriptionsHandlerIRequestHandler(IVolxyseatRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Task<IEnumerable<SubscriptionDto>> Handle(GetAllSubscriptionQuery request, CancellationToken cancellationToken)
        {
            var subscriptions = _repository.GetAll();

            var query = subscriptions.AsQueryable();

            var data = query.AsNoTracking().Select(item => new SubscriptionDto
            {
                Id = item.Id,
                Type = item._typeId,
                Status = item._statusId,
                Description = item.Description,
                Price = item.Price,
                CreatedOn = item.CreatedOn,
                UpdatedOn = item.UpdatedOn
            }).AsEnumerable();



            return Task.FromResult(data);
        }
    }
}