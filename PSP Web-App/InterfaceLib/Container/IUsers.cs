using PSP_Web_App.InterfaceLib.DTO;

namespace PSP_Web_App.InterfaceLib.Container
{
    public interface IUsers
    {
        List<UserDTO> GetUnsafeUser();
        List<UserDTO> GetSafeUser();
    }
}
