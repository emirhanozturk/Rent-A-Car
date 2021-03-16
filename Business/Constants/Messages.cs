using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UpdatedCar = "Araç bilgileri güncellendi";
        public static string AddedCar = "Araç eklendi.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string RentedCar ="Araç kiralandı.";
        public static string RentedCarError="Araç kiralama başarısız.";
        public static string Deleted="Silme başarılı.";
        public static string CarsListedById="Arabalar id'ye göre listelendi.";
        internal static string EntityAdded;
        internal static string EntityDeleted;
        internal static string EntityUpdated;
        internal static string ImageLimitExceded;
    }
}
