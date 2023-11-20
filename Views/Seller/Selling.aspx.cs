using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Seller
{
    public partial class Selling : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowBooks();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5]
                {
                    new DataColumn("ID"),
                    new DataColumn("Book"),
                    new DataColumn("Price"),
                    new DataColumn("Quantity"),
                    new DataColumn("Total")
                });
                ViewState["Bill"] = dt;
                this.BindGrid();
            }
        }

        protected void BindGrid()
        {
            BillList.DataSource = ViewState["Bill"];
            BillList.DataBind();
        }

        private void ShowBooks()
        {
            string Query = "Select * from BookTbl";
            SellingList.DataSource = Con.GetData(Query);
            SellingList.DataBind();
        }

        protected void SellingList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BillList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {

        }
    }
}