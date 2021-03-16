using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager:ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IDataResult<List<CarImage>> GetCarImages()
        {
            var result = _carImageDal.GetAll();
            return new SuccessDataResult<List<CarImage>>(result);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            var result = _carImageDal.Get(p => p.CarId == id);
            return new SuccessDataResult<CarImage>(result);
        }

        public IResult Add(IFormFile file,CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfImagesMoreThanLimit(carImage.CarId));
            if (result!=null)
            {
                return result;
            }            
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.EntityAdded);
        }

        private IResult CheckIfImagesMoreThanLimit(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId==carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }
            return new SuccessResult(Messages.AddedCar);
        }

        public IResult Delete(CarImage carImage)
        {
            var result = FileHelper.Delete(carImage.ImagePath);
            if (!result.Success)
            {
                return new ErrorResult();
            }
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.EntityDeleted);
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(c => c.Id == carImage.CarId).ImagePath, file);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.EntityUpdated);
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            var result = BusinessRules.Run(CheckIfImageNull(id));
            if (result != null)
            {
                return (IDataResult<List<CarImage>>)result;
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
        }

        private IDataResult<List<CarImage>> CheckIfImageNull(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                string path = @"\wwwroot\uploads\logo.jpg";
                List<CarImage> carImages = new List<CarImage>();
                carImages.Add(new CarImage { CarId = id, Date = DateTime.Now, ImagePath = path });
                return new ErrorDataResult<List<CarImage>>(carImages);
            }


            return new SuccessDataResult<List<CarImage>>();
        }
    }
}
