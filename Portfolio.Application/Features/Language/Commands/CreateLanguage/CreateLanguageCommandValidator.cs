using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Language.Commands.CreateLanguage
{
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageDTO>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.Value).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.");

            RuleFor(u => u.WorkerProfileId).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }
    }
}
