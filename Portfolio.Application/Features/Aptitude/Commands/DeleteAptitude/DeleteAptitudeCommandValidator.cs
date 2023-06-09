using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Aptitude.Commands.DeleteAptitude
{
    public class DeleteAptitudeCommandValidator : AbstractValidator<DeleteAptitudeDTO>
    {
        public DeleteAptitudeCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }
    }
}
