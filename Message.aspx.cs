using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    
    public partial class Message : System.Web.UI.Page
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
            }
        }
    }
}