using Business.Abstract;
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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Deleted(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<ColorDetailsDto> GetColorDetails()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetColors()
        {
            return _colorDal.GetAll();
        }

        public void Updated(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
