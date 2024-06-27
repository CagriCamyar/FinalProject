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
    }
}
