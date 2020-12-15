using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Threading.Tasks;


namespace WebPage
{
    public partial class About : Page
    {
        string sesion;

        
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Request.Cookies["Name"] != null)
            {
                TextBox2.Text = Request.Cookies["Name"].Value;

                HttpCookie cookie = new HttpCookie("Name");
                cookie.Expires = DateTime.Now.AddHours(-1d);
                Response.SetCookie(cookie);
            }


            if (Request.Cookies["Sesion"] == null)
            {

                Response.Redirect("/Default");
            }

            if (Request.Cookies["Sesion"] != null)
            {
                sesion = Request.Cookies["Sesion"].Value;
            }
            Label1.Visible = false;
            Label1.Text = sesion;


            string b = null;
            Users users = new Users();
            users = DataBase.LoadSesion(sesion);
            b = users.Login;
            if (b == "X")
            {
                users = DataBase.LoadSesion(sesion);
                b = users.Login;
            }

            if (b == "Admin" ^ b == "Admin1")
            {
              
                Label2.Visible = true;
          
            }
            Label3.Text = "Добро пожаловать! " + b;
            Label3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FE281D");

          

            int countMessage = 10;
           // Label6.Text = DataBase.LoadMessage(b, countMessage)[0];
           // Label7.Text = DataBase.LoadMessage(b, countMessage)[1];
           // Label8.Text = DataBase.LoadMessage(b, countMessage)[2];

            

           
                for (int i = countMessage; i >= 0; --i)
                {
                  try
                  {
                    myUl.InnerHtml += "<p>" + DataBase.LoadMessage(b, countMessage)[i] + "</p>";
                  }
                  catch { }
                }
                  
        }

        

        protected void Button10_Click(object sender, EventArgs e)
        {
          //  string n = null;
          //  string b;
            string ms;
            string textms;
            Users users = new Users();
            users = DataBase.LoadSesion(sesion);
            //n = users.Login;
         //   b = TextBox2.Text;
            textms = TextBox1.Text;

            ms = users.Login + ": " + textms;

            DataBase.SaveMessage(TextBox2.Text, ms);
            
            HttpCookie cookie = new HttpCookie("Name");
            cookie.Value = TextBox2.Text;
            cookie.Expires = DateTime.Now.AddHours(1);
            Response.SetCookie(cookie);


            Response.Redirect("/About");

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            string n = null;
            Users users = new Users();
            users = DataBase.LoadSesion(sesion);
            n = users.Login;
            DataBase.ClearMessage(n);

            Response.Redirect("/About");
        }
    }
}