using System;
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
        public string SelectUserByAny(int id = -1, string name = null)
        {
            if (id == -1)
            {
                if (name == null)
                {
                    return @"SELECT * FROM Userr";
                }
                else
                {
                    return @"SELECT * FROM Userr WHERE username = '" + name + "'";
                }
            }
            else
            {
                if (name == null)
                {
                    return @"SELECT * FROM Userr WHERE UserId = " + id;
                }
                else
                {
                    return @"SELECT * FROM Userr WHERE UserId = " + id + "AND username = '" + name + "'";
                }
            }
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
        public string SelectReviewByAny(int id = -1, int userid = -1, int serviceid = -1, int note = -1, string texte = null, string date = null)
        {
            string rep = "SELECT * FROM Review";
            bool next = false;
            if (id != -1 || userid != -1 || serviceid != -1 || note != -1 || texte != null || date != null)
            {
                rep += " WHERE ";
            }
            if (id != -1)
            {
                rep += "ReviewId = " + id;
                next = true;
            }
            if (userid != -1)
            {
                if (next)
                    rep += " AND ";
                else
                    next = true;
                rep += "UserId = " + userid;
                
            }
            if (serviceid != -1)
            {
                if (next)
                    rep += " AND ";
                else
                    next = true;
                rep += "ServiceId = " + serviceid;
            }
            if (note != -1)
            {
                if (next)
                    rep += " AND ";
                else
                    next = true;
                rep += "Note = " + note;
            }
            if (texte != null)
            {
                if (next)
                    rep += " AND ";
                else
                    next = true;
                rep += "Text = '" + texte + "'";
            }
            if (date != null)
            {
                if (next)
                    rep += " AND ";
                else
                rep += "Date = '" + date + "'";
            }
            return rep; 
        }

        //----------------Services------------------
        public string SelectAllServices()
        {
            return @"SELECT * FROM Service";
        }
        public string InsertService(int id, string address, string name, string type)
        {
            return @"SET IDENTITY_INSERT Service ON 
                    INSERT INTO Service(ServiceId, Adress, Name, Type)
                    VALUES (" + id + ",'" + address + "','" + name + "','" + type + "')";
        }
        public string EmptyService()
        {
            return @"DELETE FROM Service";
        }
        public string SelectServiceByAny(int id = -1, string adress = null, string name=null, string type = null)
        {
            if (name == null)
            {
                if (adress == null)
                {
                    if (id == -1)
                    {
                        if (type == null)
                            return @"SELECT * FROM Service";
                        else
                            return @"SELECT * FROM Service WHERE type LIKE '%" + type + "%'";
                    }
                    else
                    {
                        if (type == null)
                            return @"SELECT * FROM Service WHERE serviceId = " + id;
                        else
                            return @"SELECT * FROM Service WHERE type LIKE '%" + type + "%' and serviceId = " + id;
                    }
                }
                else
                {
                    if (id == -1)
                    {
                        if (type == null)
                            return @"SELECT * FROM Service WHERE adress LIKE '%" + adress + "%'";
                        else
                            return @"SELECT * FROM Service WHERE adress LIKE '%" + adress + "%'" + " AND type LIKE '%" + type + "%'";
                    }
                    else
                    {
                        if (type == null)
                            return @"SELECT * FROM Service WHERE serviceId = " + id + " AND adress LIKE '%" + adress +"%'";
                        else
                            return @"SELECT * FROM Service WHERE serviceId = " + id + " AND adress LIKE '%" + adress + "%' AND type LIKE '%" + type + "%'";
                    }
                }
            }
            else
            {
                if (adress == null)
                {
                    if (id == -1)
                    {
                        if(type == null)
                            return @"SELECT * FROM Service WHERE name LIKE '%" + name + "%'";
                        else
                            return @"SELECT * FROM Service WHERE name LIKE '%" + name + "%' AND type LIKE '%" + type + "%'";
                    }
                    else
                    {
                        if (type == null)
                            return @"SELECT * FROM Service WHERE serviceId = " + id + "AND name LIKE '%" + name + "%'";
                        else
                            return @"SELECT * FROM Service WHERE serviceId = " + id + "AND name LIKE '%" + name + "%' AND type LIKE '%" + type + "%'";
                    }
                }
                else
                {
                    if (id == -1)
                    {
                        if(type == null)
                            return @"SELECT * FROM Service WHERE adress LIKE '%" + adress + "%' AND name LIKE '%" + name +"%'";
                        else
                            return @"SELECT * FROM Service WHERE adress LIKE '%" + adress + "%' AND name LIKE '%" + name + "%' AND type LIKE '%" + type + "%'";
                    }
                    else
                    {
                        if(type == null)
                            return @"SELECT * FROM Service WHERE serviceId = " + id + " AND adress LIKE '%" + adress + "%' AND name LIKE '%" + name + "%'";
                        else
                            return @"SELECT * FROM Service WHERE serviceId = " + id + " AND adress LIKE '%" + adress + "%' AND name LIKE '%" + name + "%' AND type LIKE '%" + type + "%'";
                    }
                }
            }
        }
    }
}
