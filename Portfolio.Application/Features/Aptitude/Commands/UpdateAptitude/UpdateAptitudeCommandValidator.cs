using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Aptitude.Commands.UpdateAptitude
{
    public class UpdateAptitudeCommandValidator : AbstractValidator<UpdateAptitudeDTO>
    {
        public UpdateAptitudeCommandValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");
        }
    }
}
