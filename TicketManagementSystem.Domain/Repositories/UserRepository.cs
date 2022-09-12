using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagementSystem.Common.Entities;

namespace TicketManagementSystem.Domain.Repositories
{
    public class UserRepository : IDisposable
    {
        //private SqlConnection connection;

        public UserRepository()
        {
            //var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            //connection = new SqlConnection(connectionString);
        }

        public User GetUser(string username)
        {
            // Assume this method does not need to change and is connected to a database with users populated.
            //try
            //{
            //    string sql = "SELECT TOP 1 FROM Users u WHERE u.Username == @p1";
            //    connection.Open();

            //    var command = new SqlCommand(sql, connection)
            //    {
            //        CommandType = System.Data.CommandType.Text,
            //    };

            //    command.Parameters.Add("@p1", System.Data.SqlDbType.NVarChar).Value = username;

            //    return (User)command.ExecuteScalar();
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
            //finally
            //{
            //    connection.Close();
            //}

            if (string.IsNullOrEmpty(username) || username == "Nilsgöran")
                return null;

            if (username != "Sarah")
            {
                return new User
                {
                    Username = "Abgail123",
                    FirstName = "Abgail",
                    LastName = "Windsorman"
                };
            }
            else
            {
                return new User
                {
                    Username = "SarahIsAwesom",
                    FirstName = "Sarah",
                    LastName = "Awesom"
                };
            }
        }

        public void Dispose()
        {
            // Assume this method does not need to change.
            //connection.Dispose();
        }
    }
}
