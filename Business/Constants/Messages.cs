using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar Listelendi";
        public static string BrandLimitExceded="Marka Limiti aşıldı Yeni Marka ekleyemezsiniz";
        internal static string CarImageError="Araba resmi hata veriyor";
        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserAdded="Kullanıcı Eklendi";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
