using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental car)
        {
            if (car.ReturnDate == null)
            {
                return new ErrorResult();
            }
            _rentalDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(Rental car)
        {
            _rentalDal.Delete(car);
            return new SuccessResult(true);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail());
        }

        public IDataResult<List<Rental>> GetAllRental()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental car)
        {
            _rentalDal.Update(car);
            return new SuccessResult(true);
        }
    }
}
