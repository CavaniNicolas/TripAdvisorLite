﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Queries
    {
        //---------------Users---------------
        public string SelectAllUsers()
        {
            return @"SELECT * FROM Userr";
        }
        public string InsertUser(int id, string name)
        {
            return @"SET IDENTITY_INSERT Userr ON 
                    INSERT INTO Userr(UserId, Username)
                    VALUES (" + id + ",'" + name + "')";
        }
        public string EmptyUsers()
        {
            return @"DELETE FROM USERR";
        }
        public string SelectUserById(int id)
        {
            return @"SELECT * FROM Userr WHERE UserId = " + id;
        }

        //--------------Reviews-------------------
        public string SelectAllReviews()
        {
            return @"SELECT * FROM Review";
        }
        public string InsertReview(int id, int userid, int serviceid, int note, string texte, string date)
        {
            return @"SET IDENTITY_INSERT Review ON 
                    INSERT INTO Review(ReviewId, UserId, ServiceId, Note, Text, Date)
                    VALUES (" + id + "," + userid + "," + serviceid + "," + note + ",'" + texte + "','" + date + "')";
        }
        public string EmptyReview()
        {
            return @"DELETE FROM Review";
        }
        public string SelectReviewById(int id)
        {
            return @"SELECT * FROM Review WHERE reviewId = " + id;
        }

        //----------------Services------------------
        public string SelectAllServices()
        {
            return @"SELECT * FROM Service";
        }
        public string InsertService(int id, string address, string name)
        {
            return @"SET IDENTITY_INSERT Service ON 
                    INSERT INTO Service(ServiceId, Adress, Name)
                    VALUES (" + id + ",'" + address + "','" + name + "')";
        }
        public string EmptyService()
        {
            return @"DELETE FROM Service";
        }
        public string SelectServiceById(int id)
        {
            return @"SELECT * FROM Service WHERE serviceId = " + id;
        }
        public string SelectServiceByName(string name)
        {
            return @"SELECT * FROM Service WHERE name LIKE '" + name + "'";
        }
    }
}
