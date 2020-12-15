using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class Exit : System.Web.UI.Page
    {
        string sesion;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["Sesion"] == null)
            {

                Response.Redirect("/Default");
            }

            if (Request.Cookies["Sesion"] != null)
            {
                sesion = Request.Cookies["Sesion"].Value;

                Users users = new Users();
                users = DataBase.LoadSesion(sesion);

                DataBase.Clear(users.Login);


                HttpCookie cookie = new HttpCookie("Sesion");
                cookie.Expires = DateTime.Now.AddHours(-1d);
                Response.SetCookie(cookie);
                Response.Redirect("/Default");
            }


       //     try { sesion = Request.Cookies["Sesion"].Value; }
       //     catch { Response.Redirect("/Default"); }
       //     string y = null;
     //       Users users = new Users();
        //    users = DataBase.LoadSesion(sesion);
      //      y = users.Login;
       //     Label1.Text = y;
      //      DataBase.Clear(users.Login);


       //     HttpCookie cookie = new HttpCookie("Sesion");
      //      cookie.Expires = DateTime.Now.AddHours(-1d);
      //      Response.SetCookie(cookie);
      //      Response.Redirect("/Default");
        }


    }
}