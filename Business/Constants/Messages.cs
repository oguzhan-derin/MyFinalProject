using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 15 adet ürün olabilir.";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
        public static string CategoryLimitExceted = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied ="Yetkiniz yok.";
    }
}
