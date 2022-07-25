using Business.Abstract;
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
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public Color GetColorId(int colorId)
        {
            return _colorDal.Get(c => c.ColorId == colorId);
        }

        public List<Color> GetColors()
        {
            return _colorDal.GetCars();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
