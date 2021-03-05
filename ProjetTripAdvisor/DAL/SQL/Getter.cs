using System.Collections.Generic;
using DAL.Models;
using Microsoft.Data.SqlClient;


namespace DAL
{
    class Getter
    {
        //----------------------------------Users--------------------------------
        public List<User> GetAllUsers(SqlConnectionStringBuilder cb)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<User> list = new List<User>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectAllUsers(), connection);
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
                return list;
            }
        }

        public User GetUserById(SqlConnectionStringBuilder cb, int id)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectUserById(id), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User u = new User();
                            u.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            u.Username = reader.GetString(reader.GetOrdinal("Username"));
                            return u;
                        }
                    }
                }
            }
            return (new User());
        }

        public List<User> GetUserByAny(SqlConnectionStringBuilder cb, int id = -1, string name = null)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<User> list = new List<User>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectUserByAny(id, name), connection);
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
                return list;
            }
        }

        //----------------------------------Reviews--------------------------------
        public List<Review> GetAllReviews(SqlConnectionStringBuilder cb)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<Review> list = new List<Review>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectAllReviews(), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Review r = new Review();
                            r.ReviewId = reader.GetInt32(reader.GetOrdinal("ReviewId"));
                            r.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            r.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            r.Note = reader.GetInt32(reader.GetOrdinal("Note"));
                            r.Text = reader.GetString(reader.GetOrdinal("Text"));
                            r.Date = reader.GetString(reader.GetOrdinal("Date"));
                            list.Add(r);
                        }
                    }
                }
                return list;
            }
        }
        public Review GetReviewById(SqlConnectionStringBuilder cb, int id)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectReviewById(id), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Review r = new Review();
                            r.ReviewId = reader.GetInt32(reader.GetOrdinal("ReviewId"));
                            r.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            r.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            r.Note = reader.GetInt32(reader.GetOrdinal("Note"));
                            r.Text = reader.GetString(reader.GetOrdinal("Text"));
                            r.Date = reader.GetString(reader.GetOrdinal("Date"));
                            return r;
                        }
                    }
                }
            }
            return (new Review());
        }
        public List<Review> GetReviewByAny(SqlConnectionStringBuilder cb, int id = -1, int userid = -1, int serviceid = -1, int note = -1, string texte = null, string date = null)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<Review> list = new List<Review>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectReviewByAny(id, userid, serviceid, note, texte, date), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Review r = new Review();
                            r.ReviewId = reader.GetInt32(reader.GetOrdinal("ReviewId"));
                            r.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            r.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            r.Note = reader.GetInt32(reader.GetOrdinal("Note"));
                            r.Text = reader.GetString(reader.GetOrdinal("Text"));
                            r.Date = reader.GetString(reader.GetOrdinal("Date"));
                            list.Add(r);
                        }
                    }
                }
                return list;
            }
        }
        //----------------------------------Services--------------------------------
        public List<Service> GetAllServices(SqlConnectionStringBuilder cb)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<Service> list = new List<Service>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectAllServices(), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Service s = new Service();
                            s.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            s.Adress = reader.GetString(reader.GetOrdinal("Adress"));
                            s.Name = reader.GetString(reader.GetOrdinal("Name"));
                            list.Add(s);
                        }
                    }
                }
                return list;
            }
        }
        public Service GetServiceById(SqlConnectionStringBuilder cb, int id)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectServiceById(id), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Service s = new Service();
                            s.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            s.Adress = reader.GetString(reader.GetOrdinal("Adress"));
                            s.Name = reader.GetString(reader.GetOrdinal("Name"));
                            return s;
                        }
                    }
                }
            }
            return (new Service());
        }

        public List<Service> GetServiceByName(SqlConnectionStringBuilder cb, string name)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<Service> list = new List<Service>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectServiceByName(name), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Service s = new Service();
                            s.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            s.Adress = reader.GetString(reader.GetOrdinal("Adress"));
                            s.Name = reader.GetString(reader.GetOrdinal("Name"));
                            list.Add(s);
                        }
                    }
                }
                return list;
            }
        }

        public List<Service> GetServiceByAny(SqlConnectionStringBuilder cb, int id = -1, string adress = null, string name = null)
        {
            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();
                List<Service> list = new List<Service>();
                Queries q = new Queries();
                var cmd = new SqlCommand(q.SelectServiceByAny(id,adress,name), connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Service s = new Service();
                            s.ServiceId = reader.GetInt32(reader.GetOrdinal("ServiceId"));
                            s.Adress = reader.GetString(reader.GetOrdinal("Adress"));
                            s.Name = reader.GetString(reader.GetOrdinal("Name"));
                            list.Add(s);
                        }
                    }
                }
                return list;
            }
        }
    }

}
