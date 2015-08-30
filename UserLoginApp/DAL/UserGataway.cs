using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UserLoginApp.DAL
{
    public class UserGataway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["userConnString"].ConnectionString;
        public int GetUser(string name,string pass)
        {
            //bool IsUserExist = false;
            int id=0;
            string query = "SELECT * FROM Usertable WHERE UserName='" + name + "' and Password='"+pass+"'";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            connection.Close();
            return id;
        }
    }
}