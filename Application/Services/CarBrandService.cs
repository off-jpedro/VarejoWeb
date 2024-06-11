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
            try{

              return await _carBrandRepository.GetAll();
            }
            catch(Exception ex){
              throw new Exception($"Erro ao filtrar as marcas de carros! {ex.Message}");    
            }
            
        }

        public async Task<CarBrand> GetById(long id)
        {
            _carBrandValidator.SetValidationForGetById();

            try{
                    return await _carBrandRepository.GetById(id);
            }
            catch(Exception ex){
                throw new Exception($"Erro ao pesquisar a marca de carro! {id}");
            }
        }

        public async Task<bool> Insert(CarBrand entity)
        {
           _carBrandValidator.SetValidationForInsert();

            var sucess = await _carBrandRepository.Insert(entity);

           try{

                if(!sucess){

                    throw new Exception("Erro ao inserir a marca de carro!");
                }

                return sucess;
           }

           catch(Exception ex){

            throw new Exception($"Erro ao inserir a marca de carro!{ex.Message}");

           }
        }

        public async Task<bool> Update(CarBrand entity)
        {
           _carBrandValidator.SetValidationForUpdate();

           var sucess = await _carBrandRepository.Update(entity);

           try{

            if(!sucess){
                throw new Exception("Erro ao atualizar a marca de carro!");
            }

            return sucess;

           }
           catch (Exception ex){
            throw new Exception($"Erro ao atualizar a marca de carro!{ex.Message}");
           }
        }
        
         public async Task<bool> Delete(CarBrand entity)
        {
            _carBrandValidator.SetValidationForDelete();

            var sucess = await _carBrandRepository.Delete(entity);

            try {
                if(!sucess){
                    throw new Exception("Erro ao excluir a marca de carro!");
                }

                return sucess;
            }
            catch(Exception ex){
                 throw new Exception($"Erro ao excluir a marca de carro!{ex.Message}");
            }
        }

    }
}