using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string EntityAdded="Varlık eklendi.";
        public static string EntityDeleted="Varlık Silindi.";
        public static string EntityUpdated="Varlık güncellendi.";
        public static string UserRegistered = "Kullanıcı kaydı gerçekleşti.";
        public static string ImageLimitExceded="Resim lmiti aşıldı.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten tanımlı.";
        public static string AccessTokenCreated = "AccessToken oluşturuldu.";
    }
}
