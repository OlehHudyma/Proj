using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPage
{
    public class Users
    {
    
        public int ID;
        public string Login;
        public string Pasword;

        public Users()
        {
            this.ID = 0;
            this.Login = "X";
            this.Pasword = "X";

        }
        public Users(int id, string Login, string Pasword)
        {
            this.ID = id;
            this.Login = Login;
            this.Pasword = Pasword;

        }



    }
}