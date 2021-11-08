using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19102021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalis_Click(object sender, EventArgs e)
        {
            int rakam = int.Parse(tbRakam.Text);

            lbSonuc.Items.Clear();

            // for döngüsü
            // for(başlangıç ; şartlar ; döngü sonu)
            //int gecici = 1;
            //for ( ; gecici <= 10; )
            //{
            //    lbSonuc.Items.Add(
            //        string.Format("{0} x {1} = {2}", rakam, gecici, rakam * gecici));

            //    gecici++;
            //}

            // while döngüsü
            //  while (şartlar)
            //{         
            //
            //
            //}

            //int gecici = 1;
            //while (gecici <= 10)
            //{
            //    lbSonuc.Items.Add(
            //        string.Format("{0} x {1} = {2}", rakam, gecici, rakam * gecici));

            //    gecici = gecici + 1;
            //}

            // do{
            // while(şartlar)
            int gecici = 1;
            do
            {
                lbSonuc.Items.Add(
                    string.Format("{0} x {1} = {2}", rakam, gecici, rakam * gecici));

                //gecici++;
            } while (gecici++ <= 10);
            // ++gecici
            // gecici = gecici + 1; while(gecici <= 10);

            // gecici++
            // while(gecici <= 10); gecici = gecici + 1;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(tbBir.Text), sayi2 = int.Parse(tbIki.Text);

            // while döngüsü ile
            {
                int toplam = 0;
                int gecici = sayi1;
                while (gecici <= sayi2)
                {
                    toplam += gecici;
                    gecici++;
                }

                lblSonuc.Text = toplam.ToString();
            }

            // do-while döngüsü ile
            {
                int toplam = 0;
                int gecici = sayi1;
                do
                {
                    toplam += gecici;
                    gecici++;
                } while (gecici <= sayi2);

                lblSonuc.Text = toplam.ToString();
            }

            // for döngüsü ile
            {
                int toplam = 0;
                int gecici = sayi1;
                for (; gecici <= sayi2;)
                {
                    toplam += gecici;
                    gecici++;
                }

                lblSonuc.Text = toplam.ToString();
            }

            {
                int toplam = 0;
                for (int gecici = 1; gecici <= sayi2; gecici++)
                    toplam += gecici;
            }

            //  1 tl 50 kuruş  26 adet   25TL
            //  10 tane kafa, 30 adet ayak, kaç tavuk kaç tavşan?
            int tavuk = 1, tavsan;

            for (; true;)
            {
                tavsan = 10 - tavuk;
                if ((tavuk * 2 + tavsan * 4) == 30)
                {
                    break; // şart kontrol edilmeden döngü dışına çıkılır.
                }
                //  continue; // şart kontrol edilmeden döngünün başına gider.

                tavuk++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var sayi = rnd.Next(100); // 0..99
            sayi = rnd.Next(100);
            sayi = rnd.Next(100);
            sayi = rnd.Next(100);


            for (int x = 0; x < 10000; x++)
            {
                sayi = rnd.Next(0, 100);
                lbSonuc.Items.Add($"{sayi}");
                label1.Text = lbSonuc.Items.Count.ToString();

                //Application.DoEvents(); // Çalışmayı bekleyen Event ları çalıştırır.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int alt=1, ust=100, tutulan=0;
            int tahmin = int.Parse(textBox1.Text);

            if (tahmin < ust)
                ust = tahmin;

            if (tahmin == tutulan) ;
        }
    }
}
