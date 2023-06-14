﻿using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Language.Commands.CreateLanguage
{
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageDTO>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(u => u.NameEn).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.NameEs).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

        }
    }
}
