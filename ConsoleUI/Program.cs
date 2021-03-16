using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            //BrandManagerTest();
            //ColorManagerTest();
            Brand brand = new Brand {BrandId=2};

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(brand);
            
            

        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine("Color Id: " + color.ColorId + " Color name: " + color.ColorName);
            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(" Brand Id: " + brand.BrandId + " Brand name: " + brand.BrandName);

            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(" Car Id: " + car.CarId + " Car name: " + car.Descriptions+" Daily Price: "+car.DailyPrice);

            }
        }




    }
}
