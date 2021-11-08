using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Button1.Text = Calendar1.VisibleDate.Month.ToString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToString();
        }
    }
}