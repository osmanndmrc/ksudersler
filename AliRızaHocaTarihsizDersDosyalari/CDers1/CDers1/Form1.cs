using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. C
            // 2. C++
            // 3. C#

            int T1 = 0;
            int toplam = 0;

            // Değişken: Programın herhangi bir anında değeri değiştirile bilen sembolik isimlerdir.

            // Döngü (loop): Aynı işlemin tekrarıdır.
            for (int i = 0; i < 101; i++)
                toplam = toplam + i;

            button1.Text = toplam.ToString();

            // sabit: Değiştirilemeyen değişkenler.
            const double PI = 3.14;

            // KIYAS - KARŞILAŞTIRMA:
            // 0: False - Yanlış
            // 1: True - Doğru

            int a = 12; // int türünde a değişeni - integer(tam sayı)
            Double d = 12.23;

            // 1 1 1 1 1 1 1 1
            // 2 ^ n formülü
            //  128 64 32 16 8 4 2 1
            //  1   0  0  0  0 0 0 0

            bool esitmi = 12 == 12;

            button1.Text = esitmi.ToString();
            // ==, >, <, !=, !(Değil),
            // &&(and- ve), ||(or - veya - yada)
            int yas;
            string cinsiyet = "E";

            yas = 23;
            bool yasb = 23 >= 18;
            bool cinsb = cinsiyet == "E";

            if (yasb && cinsb && (toplam > 0 || toplam < 99))
                button1.Text = "Yetişkin-Erkek";
            else button1.Text = "Genç";

            //  Doğru ve Doğru = Doğru
            //  D     ve Y     = Yanlış
            //  Y     ve Y     = Y
            //  Y     ve D     = Y

            //  D veya D = D
            //  D veya Y = D
            //  Y veya D = D
            //  Y veya Y = Y

            //  Değil(D) = Y   !D = Y;
        }
    }
}
