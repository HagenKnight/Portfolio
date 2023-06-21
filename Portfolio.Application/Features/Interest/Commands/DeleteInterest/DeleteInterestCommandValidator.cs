using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Interest.Commands.DeleteInterest
{
    public class DeleteInterestCommandValidator : AbstractValidator<DeleteInterestDTO>
    {
        public DeleteInterestCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }
    }
}
