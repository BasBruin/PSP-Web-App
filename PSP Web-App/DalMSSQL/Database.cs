using System.Data.SqlClient;

namespace PSP_Web_App.DalMSSQL
{
    public class Database
    {
        private string connectiestring;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader reader;

        private readonly string connect;

        /// <summary>
        /// Met deze constructor set ik de connectionstring
        /// </summary>
        /// <param name="cs"> De connectionstring </param>
        public Database(string cs)
        {
            connect = cs;
        }
        public Database()
        {
            connectiestring = "Server=mssqlstud.fhict.local;Database=dbi487790_pspproject;User Id=dbi487790_pspproject;Password=Welkom12;";
        }
    }
}
