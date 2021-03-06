﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDescriptionInvalid = "Ürün açıklaması geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Arabalar Listelendi";
        public static string BrandNameInvalid = "Marka adı 2 karakterden az olamaz";
        public static string BrandAdded = "Marka Eklendi";
        public static string ColorNameInvalid = "Renk adı en az 2 harf olmalıdır";
        public static string ColorAdded = "Renk eklendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUptated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string CarCountOfBrandError = "Aynı kategoride en fazla 15 araç olabilir.";
        public static string BrandNameAlreadyExists = "Marka adı sistemde mevcuttur.";
        public static string BrandLimitExceded = "Marka limiti aşıldığı için ürün eklenemez.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kayıt olunamadı.";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
