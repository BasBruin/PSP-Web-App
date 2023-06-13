using PSP_Web_App.InterfaceLib.Container;
using PSP_Web_App.InterfaceLib.DTO;
using System.Data.SqlClient;
using System.Data;

namespace PSP_Web_App.DalMSSQL
{
    public class UserMSSQL : Database, IUsers
    {
        private readonly string connectiestring;
        private readonly Database database;
        SqlDataReader? reader;

        public UserMSSQL(string cs)
        {
            this.connectiestring = cs;
            this.database = new Database(connectiestring);
        }

        public UserDTO GetUserSafe(int ID)
        {
            UserDTO user = null;

            using (SqlConnection connection = new SqlConnection(connectiestring))
            {
                string query = "SELECT * FROM Users WHERE ID = @ID";
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserDTO(
                                Convert.ToInt32(reader["ID"]),
                                reader["Name"].ToString(),
                                reader["Email"].ToString(),
                                reader["Password"].ToString()
                            );
                        }
                    }
                }
            }

            return user;
        }

        public UserDTO GetUserNotSafe(int ID)
        {
            UserDTO user = null;

            using (SqlConnection connection = new SqlConnection(connectiestring))
            {
                string query = $"SELECT * FROM Users WHERE ID = '{ID}'";
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserDTO(
                                Convert.ToInt32(reader["ID"]),
                                reader["Name"].ToString(),
                                reader["Email"].ToString(),
                                reader["Password"].ToString()
                            );
                        }
                    }
                }
            }

            return user;
        }
    }
}
