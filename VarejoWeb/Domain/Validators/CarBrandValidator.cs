using Domain.Library;
using Domain.Models;
using Domain.Validators.Interfaces;
using FluentValidation;

namespace Domain.Validators
{
    public class CarBrandValidator : BaseValidator<CarBrand>, ICarBrandValidator 
    {
       
        public void SetValidationForGetById()
        {
            RuleFor(c => c.Id)
            .NotEqual(0).WithMessage("O Id não pode ser zero!")
            .NotNull().WithMessage("O Id não pode ser nulo!");
        }

        public void SetValidationForInsert()
        {
            RuleFor(c => c.Name)
            .NotEmpty().WithMessage("O nome não pode estar vazio!")
            .MaximumLength(50).WithMessage("Tamanho maximo de 50 caracteres!");
            
            RuleFor(c => c.Description)
            .NotEmpty().WithMessage("O nome não pode estar vazio!")
            .MaximumLength(50).WithMessage("Tamanho maximo de 50 caracteres!");
        }

        public void SetValidationForUpdate()
        {
            RuleFor(c => c.Id)
            .NotEqual(0).WithMessage("O Id não pode ser zero!")
            .NotNull().WithMessage("O Id não pode ser nulo!");

            RuleFor(c => c.Name)
            .NotEmpty().WithMessage("O nome não pode estar vazio!")
            .MaximumLength(50).WithMessage("Tamanho maximo de 50 caracteres!");
            
            RuleFor(c => c.Description)
            .NotEmpty().WithMessage("O nome não pode estar vazio!")
            .MaximumLength(50).WithMessage("Tamanho maximo de 50 caracteres!");
        }

         public void SetValidationForDelete()
        {
             RuleFor(c => c.Id)
            .NotEqual(0).WithMessage("O Id não pode ser zero!")
            .NotNull().WithMessage("O Id não pode ser nulo!");

        }
    }
}