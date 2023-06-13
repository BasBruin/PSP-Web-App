using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSP_Web_App.InterfaceLib.DTO;

namespace PSP_Web_App.BusnLogic
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public User(int id, string name, string Email, string password)
        {
            this.id = id;
            Name = name;
            Password = password;
            this.Email = Email;
        }

        public User() { }

        public User(UserDTO userdto)
        {
            id = userdto.id;
            Name = userdto.Name;
            Password = userdto.Password;
            Email = userdto.Email;
        }

        public UserDTO getDTO()
        {
            UserDTO userdto = new UserDTO(id, Name, Password, Email);
            return userdto;
        }
    }
}
