﻿using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Interest.Commands.CreateInterest
{
    public class CreateInterestCommandValidator : AbstractValidator<CreateInterestDTO>
    {
        public CreateInterestCommandValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.WorkerProfileId).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }
    }
}
