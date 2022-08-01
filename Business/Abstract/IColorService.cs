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
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Deleted(Color color);
        IResult Update(Color color);
        IDataResult<List<Color>> GetColors();
        

    }
}
