using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebPage
{
    public partial class _Default : Page
    {
        public void Redirect(string url)
        {
            
        }
        
        String sesion;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Login;
            string Pasword;
            Login = TextBox1.Text;
            Pasword = TextBox2.Text;
       //     string a;
       //     string b;
            

            Users users = new Users();
            try
            {

                users = DataBase.Load(Login, Pasword);
           //     a = users.Login;
            //    b = users.Pasword;
               
                if (users.Login == "X" && users.Pasword == "X")
                {
                    Label1.Text = "Вхід заборонено";
                    Label1.ForeColor = System.Drawing.Color.Lime; 

                }
                else { Label1.Text = "Вхід дозволено";
                
                    if (Request.Cookies["Sesion"] != null)
                    {

                        sesion = Request.Cookies["Sesion"].Value;
                    }

                    if (sesion == null)
                    {
                        Random rnd = new Random();
                        int bb = rnd.Next(0, 9999999);
                        int cc = rnd.Next(0, 7777777);
                        string vv = Convert.ToString(bb) + Convert.ToString(cc);
                        string result = "123";

                        for (int i = 0; i < vv.Length; i++)
                        {   
                            char m;
                            m = vv[i];
                            string res = Convert.ToString(m);
                            
                            if (res == "0")
                            {
                                result = result + "001";
                            }
                            if (res == "1")
                            {
                                result = result + "3Q1";
                            }
                            if (res == "2")
                            {
                                result = result + "w21ng";
                            }
                            if (res == "4")
                            {
                                result = result + "h1f";
                            }
                            if (res == "5")
                            {
                                result = "gf" + result + "w5ng";
                            }
                            if (res == "6")
                            {
                                result = "#" + result + "lhg7g";
                            }
                            if (res == "7")
                            {
                                result = result + "fy92g";
                            }
                            if (res == "8")
                            {
                                result = result + "%$12@";
                            }
                            if (res == "9")
                            {
                                result = "g" + result + "2gu2";
                            }
                        }

                        sesion = result;
                        if (sesion == result)
                        {
                            string nd = users.Login;
                            DataBase.Save(nd, sesion);
                        }
                    }

                    HttpCookie cookie = new HttpCookie("Sesion");
                    cookie.Value = sesion;
                    cookie.Expires = DateTime.Now.AddHours(5);
                    Response.SetCookie(cookie);

                    // if (Sesion == null)
                    //  {
                    //     Random rnd = new Random();
                    //     int bb = rnd.Next(0, 9999999);
                    //     int cc = rnd.Next(0, 7777777);
                    //     Sesion = Convert.ToString(bb) + Convert.ToString(cc);


                    //           Label2.Text = Convert.ToString(Sesion);
                    //       }

                    //       if (ViewState["Sesion"] != null)
                    //       { Sesion = (string)ViewState["Sesion"]; }
                    //        ViewState["Sesion"] = Sesion;
                    //        Label2.Text = Convert.ToString(Sesion);

                    //  DataBase.Save(Login, Sesion);
                      Response.Redirect("/About");
                }
            }
            catch (Exception)
            {

            }





        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        //      string Login;
        //      string Pasword;
        //      Login = TextBox1.Text;
        //      Pasword = TextBox2.Text;

            Label1.Text = Convert.ToString(TextBox1.Text.Length);
            if (TextBox1.Text.Length >= 1 && TextBox2.Text.Length >= 1)
            { 
                DataBase.SaveUsers(TextBox1.Text, TextBox2.Text);
                Button1_Click(sender, e);
            }
            else { Label1.Text = "Недоступні значення логін/пароль"; };

            
        }
    }

    public class RedirectResult
    {
    }
}