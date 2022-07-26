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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _brandDal.Add(brand);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Brand> GetBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));
        }

        public IDataResult<List<Brand>> GetBrands()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(Messages.CarsListed);
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
