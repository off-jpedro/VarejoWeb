using Data;
using Data.Interfaces;
using Domain.Models;
using Xunit;

namespace RepositoryTests
{
    public class CarBrandRepositoryTest
    {
        private CarBrandRepository _repository;

        public CarBrandRepositoryTest()
        {
            _repository = new CarBrandRepository();
        }

        [Fact]
        public async void WhenGetByAll_ReturnsCarBrands()
        {
            //Act
            var result = await _repository.GetAll();

            //Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public async void WhenGetById_ReturnsCarBrand()
        {
            //Act
            var model = new CarBrand { Id = 1 };

            //Arrange 
            var result = await _repository.GetById(model.Id);

            //Assert
            Assert.NotNull(result);
        }

         [Fact]
        public async void WhenGetById_NotReturnsCarBrand()
        {
            //Act
            var model = new CarBrand { Id = 0 };

            //Arrange 
            var result = await _repository.GetById(model.Id);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public async void WhenInsert_isValid(){
            
            //Act
            var model = new CarBrand {
                Id = 1,
                Name = "Teste",
                Description = "Description Test"
            };

            //Arrange
            var result = await _repository.Insert(model);

            //Assert
            Assert.True(result);
        }

        // [Fact]
        // public async void WhenInsert_isInvalid(){
            
        //     //Act
        //     var model = new CarBrand {
        //     };

        //     //Arrange
        //     var result = await _repository.Insert(model);

        //     //Assert
        //     Assert.False(result);
        // }

        [Fact]
        public async void WhenUpdate_isValid()
        {
            // Arrange
            var entity = new CarBrand {
            Id = 1, 
            Name = "Name Test",
            Description = "Description Test"
            };

            // Act
            var result = await _repository.Update(entity);

            // Assert
            Assert.True(result);
        }

         [Fact]
        public async void WhenUpdate_isInValid()
        {
            // Arrange
            var entity = new CarBrand {
            Id = 0, 
            Name = "Name Test",
            };

            // Act
            var result = await _repository.Update(entity);

            // Assert
            Assert.False(result);
        }
        
        [Fact]
        public async void WhenDelet_isValid(){
            //Act
            var entity = new CarBrand { Id = 1};

            //Arrange
            var result = await _repository.Delete(entity);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public async void WhenDelet_isInValid(){
            //Act
            var entity = new CarBrand { Id = 0};

            //Arrange
            var result = await _repository.Delete(entity);

            //Assert
            Assert.False(result);
        }
    }
}