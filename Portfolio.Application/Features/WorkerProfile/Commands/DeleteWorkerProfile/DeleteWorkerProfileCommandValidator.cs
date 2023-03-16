using FluentValidation;
using Portfolio.Core.DTO.WorkerProfile;

namespace Portfolio.Application.Features.WorkerProfile.Commands.DeleteWorkerProfile
{
    public class DeleteWorkerProfileCommandValidator : AbstractValidator<DeleteWorkerProfileDTO>
    {
        public DeleteWorkerProfileCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                 .NotEmpty().WithMessage("You must chose a {PropertyName}.")
                 .GreaterThan(0).WithMessage("The {PropertyName} index should be greater than 0.");
        }
    }
}
