using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAllRental();
        IResult Add(Rental car);
        IResult Update(Rental car);
        IResult Delete(Rental car);
        IDataResult<List<RentalDetailDto>> GetRentalDetail();
    }
}
