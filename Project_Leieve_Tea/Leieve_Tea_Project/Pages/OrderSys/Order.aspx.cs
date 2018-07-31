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
        public static double gst;
        public static double total;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (!Request.IsAuthenticated)
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
                else
                {
                    if (!User.IsInRole(SecurityRoles.WebsiteAdmins))
                    {
                        Response.Redirect("~/Account/Login.aspx");
                    }
                }
            }
        }

        protected void AddMenuItemLB_Command(object sender, CommandEventArgs e)
        {
            string[] sub = e.CommandArgument.ToString().Split(',');
            subtotal += double.Parse(sub[1]);
            SubtotalTextBox.Text =  subtotal.ToString();

            gst = subtotal* 0.05;
            GSTTextBox.Text = gst.ToString("#.##");

            total = subtotal + gst;
            TotalTextBox.Text = total.ToString("#.##");
        }

    }
}