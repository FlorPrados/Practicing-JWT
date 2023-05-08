using Jwt.Models;

namespace Jwt.Constants
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel(){Username = "fprados", Password = "key12345", Rol = "Developer",EmailAdress = "fprados@gmail.com", Fullname = "Florencia Prados"},
            new UserModel(){Username = "dorce", Password = "key12345", Rol = "Developer",EmailAdress = "dorce@gmail.com", Fullname = "Patricio Orce"},
            new UserModel(){Username = "boscar", Password = "keykey123", Rol = "Admin",EmailAdress = "boscar@gmail.com", Fullname = "Bruno Oscar"}
        };
    }
}
