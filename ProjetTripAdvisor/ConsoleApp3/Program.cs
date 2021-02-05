using DAL.Models;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static string TestQuerySql()
        {
            return @"SELECT * FROM Userr";
        }
        static void Main(string[] args)
        {
            //Server=tcp:tripadvisordb.database.windows.net,1433;Initial Catalog=tripadvisorDB;Persist Security Info=False;User ID=sheep;Password=ISIMAisima2021!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";

            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(TestQuerySql(), connection);

                List<User> list = new List<User>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User u = new User();
                            u.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            u.Username = reader.GetString(reader.GetOrdinal("Username"));
                            list.Add(u);
                        }
                    }
                }
                foreach(User u in list)
                    Console.WriteLine(u.UserId + u.Username);
            }
        }
    }
}



/* //test validators
Customer customer = new Customer();
            customer.Surname="toto";
            customer.Forename = "pcpc";
            //customer.Address = "17 rue";
            CustomerValidator validator = new CustomerValidator();

            ValidationResult results = validator.Validate(customer);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

            string allMessages = results.ToString("~");
*/