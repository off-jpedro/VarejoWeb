using Domain.Models;
using Domain.Validators;

namespace ValidatorsTests
{
    public class CarBrandValidatorTest
    {
        private CarBrandValidator _carBrandValidator;

        public CarBrandValidatorTest()
        {
            _carBrandValidator = new CarBrandValidator();
        }

        [Fact]
        public void WhenModelsGetById_ReturnIsValid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 1,
            };

            //Act
           _carBrandValidator.SetValidationForGetById();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsGetById_ReturnIsInvalid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 0,
            };

            //Act
           _carBrandValidator.SetValidationForGetById();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.False(result.IsValid);
        }

        [Fact]
        public void WhenModelsInsert_IsValid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 1,
                Name = "Fiat",
                Description = "Marca Fiat"
            };

            //Act
           _carBrandValidator.SetValidationForInsert();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsInsert_IsInvalid()
        {
            //Arrange
            var carBrand = new CarBrand{
                //Id = 1,
                //Name = "Fiat",
                //Description = "Marca Fiat"
            };

            //Act
           _carBrandValidator.SetValidationForInsert();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.False(result.IsValid);
        }

        [Fact]
        public void WhenModelsUpdate_IsValid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 1,
                Name = "Fiat",
                Description = "Marca Fiat"
            };

            //Act
           _carBrandValidator.SetValidationForUpdate();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsUpdate_IsInvalid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 0,
                //Name = "Fiat",
                //Description = "Marca Fiat"
            };

            //Act
           _carBrandValidator.SetValidationForUpdate();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.False(result.IsValid);
        }

        [Fact]
        public void WhenModelsDelete_IsValid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 1,
                Status = Domain.Enums.Status.Inactive
            };

            //Act
           _carBrandValidator.SetValidationForDelete();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsDelete_IsInvalid()
        {
            //Arrange
            var carBrand = new CarBrand{
                Id = 0,
            };

            //Act
           _carBrandValidator.SetValidationForDelete();
            var result = _carBrandValidator.Validate(carBrand);
    
            //Assert
            Assert.False(result.IsValid);
        }

    }
}