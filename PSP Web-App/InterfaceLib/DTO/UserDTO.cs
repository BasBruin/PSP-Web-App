namespace PSP_Web_App.InterfaceLib.DTO
{
    public class UserDTO
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }


        public UserDTO(int id, string name, string password, string Email)
        {
            this.id = id;
            Name = name;
            Password = password;
            this.Email = Email;
        }
    }
}
