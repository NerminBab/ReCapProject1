using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _colorDal.Add(color);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Color> GetColorId(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }

        public IDataResult<List<Color>> GetColors()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetCars(), Messages.CarsListed);
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
