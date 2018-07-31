using AppSecurity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leieve_Tea_Project.Pages.OrderSys
{
    public partial class Order : System.Web.UI.Page
    {
        public static double subtotal;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
            }
        }

        protected void AddMenuItemLB_Command(object sender, CommandEventArgs e)
        {
            string[] sub = e.CommandArgument.ToString().Split(',');
            subtotal += double.Parse(sub[1]);
            SubtotalTextBox.Text =  subtotal.ToString();

            double gst = subtotal* 0.05;
            GSTTextBox.Text = gst.ToString("0.##");

            double pst = subtotal * 0.07;
            GSTTextBox.Text = pst.ToString("0.##");

            double total = subtotal + gst;
            TotalTextBox.Text = total.ToString("0.##");
        }

    }
}