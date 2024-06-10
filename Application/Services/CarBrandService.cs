using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Domain.Models;
using Domain.Validators.Interfaces;
using VarejoWeb.Service.Interfaces;

namespace VarejoWeb.Service
{
    public class CarBrandService : ICarBrandService
    {
        private readonly new ICarBrandRepository _carBrandRepository;
        private readonly new ICarBrandValidator _carBrandValidator;

        public CarBrandService(ICarBrandRepository carBrandrepository, ICarBrandValidator carBrandValidator)
        {
            _carBrandRepository = carBrandrepository;
            _carBrandValidator = carBrandValidator;
        }
       
        public async Task<IEnumerable<CarBrand>> GetAll()
        {
            var  result = await _carBrandRepository.GetAll();
            return result;
        }

        public Task<CarBrand> GetById(long id)
        {
        }

        public Task<bool> Insert(CarBrand entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CarBrand entity)
        {
            throw new NotImplementedException();
        }
        
         public Task<bool> Delete(CarBrand entity)
        {
            throw new NotImplementedException();
        }

    }
}