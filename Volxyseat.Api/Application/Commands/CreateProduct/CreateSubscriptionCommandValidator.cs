﻿using FluentValidation;
using Volxyseat.Api.Application.Commands.CreateSubscription;
using Volxyseat.Domain.Repositories;

namespace Volxyseat.Api.Application.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandValidator : AbstractValidator<CreateSubscriptionCommand>
    {
        private readonly IVolxyseatRepository _repository;

        public CreateSubscriptionCommandValidator(IVolxyseatRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

            RuleFor(x => x.TypeId)
                .IsInEnum().WithMessage("Invalid TypeId")
                .NotEmpty().WithMessage("TypeId is required");

            RuleFor(x => x.StatusId)
                .IsInEnum().WithMessage("Invalid StatusId")
                .NotEmpty().WithMessage("StatusId is required");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required")
                .MaximumLength(255).WithMessage("Description must be less than 255 characters");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Price must be greater than zero");

            RuleFor(x => x.CreatedOn)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("CreatedOn cannot be in the future");

            RuleFor(x => x.UpdatedOn)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("UpdatedOn cannot be in the future");
        }
    }
}