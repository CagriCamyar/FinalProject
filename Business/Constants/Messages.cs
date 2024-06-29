using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages //newlenmesın dıye static yazdım
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürünün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 urun olabilir";
        public static string ProductNameAlreadyExist = "Bu Urun isminda daha once urun eklenmis";
        public static string CategoryLimitExceded = "Kategori Limiti Asildigi Icin Yeni Urun Eklenemiyor";
        public static string AuthorizationDenied = "Bu Islemi Yapmak Icin Yetkiniz Yok";
        public static string UserRegistered = "Kayit Basarili";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError = "Hatali Parola Girdiniz";
        public static string SuccessfulLogin = "Giris Basarili";
        public static string UserAlreadyExists = "Kullanici Mevcut";
        public static string AccessTokenCreated = "Token  Olusturuldu";
    }
}
