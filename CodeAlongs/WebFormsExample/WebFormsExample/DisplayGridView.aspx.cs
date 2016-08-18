using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExample
{
    public partial class DisplayGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet myData = new DataSet();
            string filePath = Server.MapPath("~/App_Data/");
            OleDbConnection myconn = new OleDbConnection(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";" +
                "Extended Properties=\"text;HDR=NO;FMT=Delimited\"");

            string myQuery = "SELECT F1 AS StudentId, F2 AS [Student Name], F3 AS Course " +
                             "FROM file.txt";

            OleDbDataAdapter cmd = new OleDbDataAdapter(myQuery, myconn);

            cmd.Fill(myData, "Apprentices");
            myconn.Close();
            gvwData.DataSource = myData;
            gvwData.DataBind();

            Apprentices = new DataTable();
            cmd.Fill(Apprentices);
        }

        public DataTable Apprentices
        {
            get { return (DataTable) ViewState["TableData"]; }
            set { ViewState["TableData"] = value; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable myTable = Apprentices;

            DataSet ds = new DataSet();
            ds.Merge(myTable.Select("Course = '.NET'"));
            gvwData.DataSource = ds;
            gvwData.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            gvwData.DataSource = Apprentices;
            gvwData.DataBind();
        }
    }
}