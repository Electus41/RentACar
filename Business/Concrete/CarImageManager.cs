using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;

using Core.Utilities.FileUploads;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarIMageAmount(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            

            carImage.ImagePath = FileHelper.Add(file);//guidname+type

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ImagesAdded);


        }

        public IResult Delete(CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.Id == carImage.Id);
            FileHelper.Delete(result.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);

        }
        public IResult Update(IFormFile file, CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.Id == carImage.Id);
            var result1 = FileHelper.Update(file, result.ImagePath);
            carImage.ImagePath = result1;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }




        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetById(int id)
        {
            var result = _carImageDal.Get(c => c.Id == id);
            if (result.ImagePath == null)
            {
                List<CarImage> Cimage = new List<CarImage>();
                Cimage.Add(new CarImage { CarId = id, ImagePath = @"\Default.jpg" });
                return new SuccessDataResult<List<CarImage>>(Cimage);

            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(b => b.Id == id));
        }
        public IDataResult<List<CarImage>> GetByCarId(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id);


            if (!result.Any())
            {

                return new SuccessDataResult<List<CarImage>>
                    (new List<CarImage> { new CarImage { CarId = id, ImagePath = "Default.jpg" } });

            }

            return new SuccessDataResult<List<CarImage>>(result);
        }






        private IResult CheckCarIMageAmount(int CarId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == CarId);

            if (result.Count > 5)
            {
                return new ErrorResult();
            }

            return new SuccessResult();

        }

    }
}
