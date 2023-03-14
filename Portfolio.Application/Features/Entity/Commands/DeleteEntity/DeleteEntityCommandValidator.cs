using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Features.Entity.Commands
{
    public class DeleteEntityCommandValidator : AbstractValidator<DeleteEntityDTO>
    {
        public DeleteEntityCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("You must chose a {PropertyName}.")
                .GreaterThan(0).WithMessage("The {PropertyName} index should be greater than 0.");
        }
    }
}
