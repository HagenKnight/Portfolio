using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Language.Commands.DeleteLanguage
{
    public class DeleteLanguageCommandValidator : AbstractValidator<DeleteLanguageDTO>
    {
        public DeleteLanguageCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }
    }
}
