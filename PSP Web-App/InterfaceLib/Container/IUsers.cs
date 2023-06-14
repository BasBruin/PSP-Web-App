using PSP_Web_App.InterfaceLib.DTO;

namespace PSP_Web_App.InterfaceLib.Container
{
    public interface IUsers
    {
        UserDTO GetUserNotSafe(string id);
        UserDTO GetUserSafe(int id);
    }
}
