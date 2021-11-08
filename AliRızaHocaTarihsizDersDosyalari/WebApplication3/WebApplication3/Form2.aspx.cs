using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(tbKA.Text == "1" && tbS.Text == "1")
            {
                Label1.Text = "Giriş doğru.";
            }
            else
            {
                Label1.Text = "Giriş yanlış.";
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
                Label2.Text = "Kapalı.";
            else Label2.Text = "Açık.";
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Label3.Text = RadioButtonList1.Items[0].Text;
            lblRadioButtons.Text = RadioButtonList1.Items[RadioButtonList1.SelectedIndex].Text;
        }

        protected void RadioButtonList1_TextChanged(object sender, EventArgs e)
        {
            lblRadioButtons.Text = RadioButtonList1.SelectedValue;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void CheckBoxList1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}