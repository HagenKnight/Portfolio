using FluentValidation;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Features;

namespace Portfolio.Application.Features.WorkerProfile.Commands.CreateWorkerProfile
{
    internal class CreateWorkerProfileCommandValidator : AbstractValidator<CreateWorkerProfileDTO>
    {
        public CreateWorkerProfileCommandValidator()
        {
            RuleFor(u => u.FirstName).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.LastName).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.AboutMe).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(10, 600).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.Email).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(10, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.")
               .Must(u => RegexExtensions.VerifyValue(u, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")).WithMessage("Wrong {PropertyName} format: {PropertyValue}."); ;

            RuleFor(u => u.Phone).Cascade(CascadeMode.Stop)
                .Must(u => !string.IsNullOrEmpty(u)).WithMessage("{PropertyName} property value is required.")
                .Must(u => RegexExtensions.VerifyValue(u, @"(\(\d{2}\)[.-]?|\d{2}[.-]?)?\d{4}[.-]?\d{4}$")).WithMessage("Wrong {PropertyName} format: {PropertyValue}.");

            RuleFor(u => u.Address).Cascade(CascadeMode.Stop)
                .Must(u => !string.IsNullOrEmpty(u)).WithMessage("{PropertyName} property value is required.")
                .Must(u => RegexExtensions.VerifyValue(u, @"^[\w\s]{2,255}$")).WithMessage("Wrong {PropertyName} format: {PropertyValue}.");

            RuleFor(u => u.City).Cascade(CascadeMode.Stop)
                .Must(u => !string.IsNullOrEmpty(u)).WithMessage("{PropertyName} property value is required.")
                .Must(u => RegexExtensions.VerifyValue(u, @"^[\w\s]{2,255}$")).WithMessage("Wrong {PropertyName} format: {PropertyValue}.");

            RuleFor(u => u.CountryId)
                .NotEmpty().WithMessage("You must chose a {PropertyName}.")
                .GreaterThan(0).WithMessage("The {PropertyName} index should be greater than 0.");

        }
    }
}
