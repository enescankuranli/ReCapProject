using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update (IFormFile formFile, CarImage carImage);

        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IDataResult<CarImage> GetByImageId(int imageId);
    }
}
