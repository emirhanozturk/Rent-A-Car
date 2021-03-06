﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId, ColorId = co.ColorId,
                                 BrandId = b.BrandId, DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,BrandName = b.BrandName, 
                                 ColorName = co.ColorName,Descriptions = c.Descriptions
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
