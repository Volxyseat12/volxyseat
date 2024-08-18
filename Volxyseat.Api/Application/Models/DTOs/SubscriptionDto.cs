using System;

namespace Volxyseat.Api.Application.DTOs
{
    public class SubscriptionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public SubscriptionDto()
        {
            Id = Guid.NewGuid();
        }


    }
}
