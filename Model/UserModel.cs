using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public void Clear()
        {
            Username = null;
            Password = null;
            Role = null;
        }


    }
 }