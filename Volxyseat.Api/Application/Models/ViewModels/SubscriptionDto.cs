﻿using Volxyseat.Domain.Models;

namespace Volxyseat.Api.Application.Models.ViewModels
{
    public class SubscriptionDto
    {
        public Guid Id { get; set; }
        public SubscriptionTypeEnum Type { get; set; }
        public SubscriptionStatusEnum Status { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}