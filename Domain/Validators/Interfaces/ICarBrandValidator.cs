using Domain.Models;
using FluentValidation;

namespace Domain.Validators.Interfaces
{
    public interface ICarBrandValidator : IValidator<CarBrand>
    {
        public void SetValidationForGetById();

        public void SetValidationForInsert();

        public void SetValidationForUpdate();

        public void  SetValidationForDelete();

    }
}