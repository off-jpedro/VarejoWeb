using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace VarejoWeb.Service.Interfaces
{
    public interface ICarBrandService
    {
        Task<IEnumerable<CarBrand>> GetAll();
        Task<CarBrand> GetById(long id);
        Task<bool> Insert(CarBrand entity);
        Task<bool> Update(CarBrand entity);
        Task<bool> Delete(CarBrand entity);
    }
}