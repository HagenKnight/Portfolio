using FluentValidation;
using Portfolio.Core.DTO.Resume;

namespace Portfolio.Application.Features.Resume.Commands.CreateResume
{
    public class CreateResumeCommandValidator : AbstractValidator<CreateResumeDTO>
    {
        public CreateResumeCommandValidator()
        {
            RuleFor(u => u.InstitutionName).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.Title).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.Description).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(10, 600).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.StartDate).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .GreaterThanOrEqualTo(new DateTime(1950, 1, 1)).WithMessage("{PropertyName} is less than {PropertyValue}. DateTime not allowed.");

            RuleFor(u => u.FinishDate).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .LessThanOrEqualTo(DateTime.Now).WithMessage("{PropertyName} is greater than {PropertyValue}. DateTime not allowed.");


        }
    }
}
