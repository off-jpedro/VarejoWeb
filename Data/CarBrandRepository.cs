using System.Data.Common;
using Data.Factory.Interfaces;
using Data.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Logging;

namespace Data
{
    public class CarBrandRepository : ICarBrandRepository
    {

        //private readonly ILogger<CarBrandRepository> _logger;

        //TODO: Ainda nao definimos banco de dados, vamos usar dados mockados
        private List<CarBrand> _listCarBrand = new List<CarBrand>();

        public CarBrandRepository(/*ILogger<CarBrandRepository> logger*/)
        {
            //_logger = logger;

            //TODO: Ainda nao definimos banco de dados, vamos usar dados mockados
            this._listCarBrand.Add(new CarBrand { Id = 1, Name = "Ford", Description = "Marca Ford" });
            this._listCarBrand.Add(new CarBrand { Id = 2, Name = "Fiat", Description = "Marca Fiat" });
            this._listCarBrand.Add(new CarBrand { Id = 3, Name = "Toyota", Description = "Marca Toyota" });
            this._listCarBrand.Add(new CarBrand { Id = 4, Name = "Volkswagen", Description = "Marca Volkswagen" });
            this._listCarBrand.Add(new CarBrand { Id = 5, Name = "Hyundai", Description = "Marca Hyundai" });
            this._listCarBrand.Add(new CarBrand { Id = 6, Name = "Chevrolet", Description = "Marca Chevrolet" });
        }

        public Task<IEnumerable<CarBrand>> GetAll()
        {
            return Task.FromResult(_listCarBrand.AsEnumerable());
        }

        public Task<CarBrand> GetById(long id)
        {
            var entity = this._listCarBrand.FirstOrDefault( x => x.Id == id );
            
            if(entity != null){
                return Task.FromResult(entity);    
            }
            return Task.FromResult<CarBrand>(null);
        }

        public Task<bool> Insert(CarBrand entity)
        {
            entity.Id = this._listCarBrand.Count + 1;

            this._listCarBrand.Add(entity);

            return Task.FromResult(true);
        }

        public Task<bool> Update(CarBrand entity)
        {
            var model = this._listCarBrand.FirstOrDefault(x => x.Id == entity.Id);
            
            if(model != null){
                model.Name = entity.Name;
                model.Description = entity.Description;
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

         public Task<bool> Delete(CarBrand entity)
        {
            var model = this._listCarBrand.FirstOrDefault(x => x.Id == entity.Id);

            if(model != null){
                this._listCarBrand.Remove(model);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}