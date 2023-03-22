using FluentValidation;
using Portfolio.Core.DTO.Resume;

namespace Portfolio.Application.Features.Resume.Commands.DeleteResume
{
    public class DeleteResumeCommandValidator : AbstractValidator<DeleteResumeDTO>
    {
        public DeleteResumeCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                 .NotEmpty().WithMessage("You must chose a {PropertyName}.")
                 .GreaterThan(0).WithMessage("The {PropertyName} index should be greater than 0.");
        }
    }
}
