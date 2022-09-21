using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "CarAdded";
        public static string DescriptionInvalid = "Description Invalid";
        public static string MaintenanceTime = "Maintenance Time..!!";
        public static string CarsListed = "CarsListed";
        public static string Deleted = "Araba Silindi";
        public static string Updated = "Araba Güncellendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandNameInvalid = "Marka ismi Hatalı";
        internal static string ImagesAdded = "Images Added";
        internal static string UserRegistered;
        internal static string UserNotFound;
        internal static string PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static string AuthorizationDenied;
    }
}
