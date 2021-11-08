using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace W26102021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewRefresh();
            //DERSEntities con = new DERSEntities();

            //con.KULLANICI.Load();    // VT tnından tabloyu uygulamaya yükler.
            //GridView1.DataSource = con.KULLANICI.Local;    // Uygulamaya yüklenen data GV ye yüklenir
            //GridView1.DataBind();                          //     "          "      "   "  "    "
        }

        public void GridViewRefresh()
        {
            DERSEntities con = new DERSEntities();

            con.KULLANICI.Load();    // VT tnından tabloyu uygulamaya yükler.
            GridView1.DataSource = con.KULLANICI.Local;    // Uygulamaya yüklenen data GV ye yüklenir
            GridView1.DataBind();
        }

        protected void btGiris_Click(object sender, EventArgs e)
        {
            DERSEntities con = new DERSEntities();

            string kadi = tbKADI.Text, sifre = tbSifre.Text;

            var sor = (from kayit in con.KULLANICI
                       where kayit.KADI == kadi && kayit.SIFRE == sifre
                       select kayit).ToList();
            if (sor.Count == 1)
            {
                lblSonuc.Text = "Giriş başarılı";
            }
            else { lblSonuc.Text = "Giriş başarısız."; }
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            DERSEntities con = new DERSEntities();

            string kadi = tbEkleKADI.Text, sifre = tbEkleSifre.Text;

            KULLANICI kayit = new KULLANICI();
            kayit.KADI = kadi;
            kayit.SIFRE = sifre;

            con.KULLANICI.Add(kayit);
            con.SaveChanges();

            GridViewRefresh();   // GridView i yeniden yükler
        }

        protected void btnDuzelt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbDID.Text);

            string kadi = tbDKADI.Text, sifre = tbDSifre.Text;

            DERSEntities con = new DERSEntities();

            var sorgu = (from kayit in con.KULLANICI
                         where kayit.ID == id
                         select kayit).ToList();

            if (sorgu.Count == 1)
            {
                if (kadi.Trim() != "")
                    sorgu[0].KADI = kadi;

                if (!string.IsNullOrEmpty(sifre))
                    sorgu[0].SIFRE = sifre;

                con.SaveChanges();

                lblD.Text = "Değişiklik kaydedildi.";
            }

            GridViewRefresh();
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            DERSEntities con = new DERSEntities();

            int id = int.Parse(tbDegistirID.Text);

            var sorgu = (from kayit in con.KULLANICI
                         where kayit.ID == id
                         select kayit).ToList();

            if (sorgu.Count == 1)
            {
                con.KULLANICI.Remove(sorgu[0]);
                con.SaveChanges();
                lblSil.Text = "Kullanıcı silindi.";
            }
            else
            {
                lblSil.Text = "Kullanıcı bulunamadı.";
            }

            GridViewRefresh();
        }
    }
}