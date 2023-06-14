using PSP_Web_App.InterfaceLib.Container;
using PSP_Web_App.InterfaceLib.DTO;
using System.Text;

namespace PSP_Web_App.BusnLogic
{
    public class UserContainer
    {
        public readonly IUsers iUsers;


        public UserContainer(IUsers iuser)
        {
            iUsers = iuser;
        }

        public User GetUserNotSafe(string id)
        {
            User user = new(iUsers.GetUserNotSafe(id));
            return user;
        }

        public User GetUserSafe(int id)
        {
            User user = new(iUsers.GetUserSafe(id));
            return user;
        }

    }
}
