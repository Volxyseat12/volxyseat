﻿using Volxyseat.Domain.Models;

namespace Volxyseat.Api.Application.Models.ViewModels
{
    public class SubscriptionDto
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public SubscriptionEnum Type { get; set; }
        public SubscriptionStatus Status { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
