using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi...";
        public static string ProductNameInValid = "Ürün ismi geçersiz...";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir ";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün ekleyemezsiniz.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied ="Yetkisiz Kullanıcı...";
        public static string UserRegistered="Kayıt Olundu";
        public static string UserNotFound ="Kullanıcı bulunamadı...";
        public static string PasswordError ="Yanlış parola";
        public static string SuccessfulLogin="Griş Başarılı";
        public static string UserAlreadyExists="Bu isimde kullanıcı mevcut";
        public static string AccessTokenCreated="Access Token oluşturuldu";
    }
}
