using DAL.Models;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Server=tcp:tripadvisordb.database.windows.net,1433;Initial Catalog=tripadvisorDB;Persist Security Info=False;User ID=sheep;Password=ISIMAisima2021!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            QueriesSQL q = new QueriesSQL();
            Getter g = new Getter();

            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(q.SelectAllUsers(), connection);
                cmd.ExecuteReader();
            }

            List<User> list_user = g.GetAllUsers(cb);
            foreach (User u in list_user)
                Console.WriteLine(u);

            Console.WriteLine(g.GetUserById(cb, 20));

            List<Review> list_review = g.GetAllReviews(cb);
            foreach (Review r in list_review)
                Console.WriteLine(r.Note + r.Text);

            List<Service> list_service = g.GetAllServices(cb);
            foreach (Service s in list_service)
                Console.WriteLine(s.Name + s.Adress);


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