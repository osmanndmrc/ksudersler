using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDers1
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Button1.Visible = !Button1.Visible;

            if (Button1.Visible)
                Button1.Visible = false;
            else Button1.Visible = true;
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Button2.Text = Calendar1.VisibleDate.Month.ToString();
        }
    }
}