using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C01112021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
        Zipla:
            button1.Text = $"{sayac}"; //sayac.ToString();
            Application.DoEvents();

            sayac++;
            if (sayac < 10000)
                goto Zipla;
            

            {
                while (sayac < 10000)
                {
                    button1.Text = $"{sayac}"; //sayac.ToString();
                    Application.DoEvents();

                    sayac++;
                }
            }
            
            button1.Text = "Dönü bitti.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
