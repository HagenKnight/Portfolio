using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Entity.Commands
{
    public class UpdateEntityCommandValidator : AbstractValidator<UpdateEntityDTO>
    {
        public UpdateEntityCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }
    }
}
