﻿using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayers;
namespace MVCPros.Models
{
    public class Users : DataAccess
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        private Users user { get; set; }
        private List<Users> users { get; set; }

        public Users()
        { }
        public List<Users> ReturnUsers()
        {
            users = new List<Users>();
            user = new Users();


            foreach (DataRow row in user.ReturnData().Rows)
            {
                user = new Users();
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserName = row["UserName"].ToString();
                user.UserEmail = row["UserEmail"].ToString();
                users.Add(user);
            }
            return users;
        }
        //user login
        public Users ReturnUser(int id)
        {
            user = new Users();

            foreach (DataRow row in user.ReturnData(id).Rows)
            {
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserName = row["UserName"].ToString();
                user.UserEmail = row["UserEmail"].ToString();
                user.UserPassword = row["UserPassword"].ToString();

            }

            return user;
        }
    }
}

