using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace W19102021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            if (tbKA.Text == "1" && tbSifre.Text == "1")
                lblSonuc.Text = "Giriş başarılı";
            else lblSonuc.Text = "Giriş başarısız.";

            Database1Entities con = new Database1Entities();  // Veri tabanına bağlanır.

            var q = (from rec in con.KISI
                     select rec).ToList();

            if (q[0].ADI == tbKA.Text && q[0].SOYADI == tbSifre.Text)
                lblSonuc.Text = "Giriş başarılı";
            else lblSonuc.Text = "Giriş başarısız.";
        }
    }
}