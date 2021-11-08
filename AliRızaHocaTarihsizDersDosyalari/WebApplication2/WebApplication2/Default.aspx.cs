using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
        }

        protected void btnİslem_Click(object sender, EventArgs e)
        {
            if (tbKA.Text == "" && tbSifre.Text == "")
                Label1.Text = "Şifre doğru";
            else Label1.Text = "Şifre yanlış";
        }
    }
}