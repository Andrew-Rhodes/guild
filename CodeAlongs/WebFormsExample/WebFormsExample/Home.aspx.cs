using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExample
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            btnGoToPage.Text = "Final Frontier!";
            txtField1.Font.Size = FontUnit.XLarge;
            Button1.BackColor = Color.BlueViolet;
        }

        protected void btnGoToPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("NEwPage.aspx?field1=" + txtField1.Text);
        }
    }
}