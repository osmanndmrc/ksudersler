using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace W22102021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "Bir şey";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Database1Entities baglanti = new Database1Entities();

            var q = (from kayit in baglanti.KULLANICI
                     select kayit).ToList();

            if (tbKA.Text == q[0].AD_SOYAD && tbS.Text == q[0].SIFRE)
                lbDurum.Text = "Giriş başarılı";
            else lbDurum.Text = "Giriş başarısız";

            lbDurum.Text = (tbKA.Text == "1" && tbS.Text == "1") ? "Giriş başarılı" : "Giriş başarısız";
        }
    }
}