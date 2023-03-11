using FluentValidation;
using Portfolio.Core.DTO;

namespace Portfolio.Application.Validators
{
    public class EntityValidator : AbstractValidator<EntityDTO>
    {
        public EntityValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("El nombre de Género es necesario.")
                .Length(3, 50).WithMessage("Debe tener una longitud entre {MinLength} y {MaxLength} caracteres.");
        }
    }
}
