using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Deleted(Color color);
        void Updated(Color color);
        List<Color> GetColors();
        List<ColorDetailsDto> GetColorDetails();

    }
}
