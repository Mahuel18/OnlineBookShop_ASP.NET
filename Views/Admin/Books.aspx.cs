using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowBooks();
                GetCategories();
                GetAuthors();
            }
            
        }
        private void ShowBooks()
        {
            string Query = "Select * from BookTbl";
            BookList.DataSource = Con.GetData(Query);
            BookList.DataBind();

        }
        private void GetCategories()
        {
            string Query = "Select * from CategoryTbl";
            BCatCb.DataTextField = Con.GetData(Query).Columns["CatName"].ToString();
            BCatCb.DataValueField = Con.GetData(Query).Columns["CatId"].ToString();
            BCatCb.DataSource = Con.GetData(Query);
            BCatCb.DataBind();
        }
        private void GetAuthors()
        {
            string Query = "Select * from AuthorTbl";
            BAuthCb.DataTextField = Con.GetData(Query).Columns["AutName"].ToString();
            BAuthCb.DataValueField = Con.GetData(Query).Columns["AutId"].ToString();
            BAuthCb.DataSource = Con.GetData(Query);
            BAuthCb.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || BPriceTb.Value == "" || BQuanTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuthor = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(BPriceTb.Value);
                    int Quantity = Convert.ToInt32(BQuanTb.Value);

                    string Query = "Insert into BookTbl values('{0}', '{1}', '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, BName, BAuthor, BCategory, Quantity, Price);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book Inserted!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    BPriceTb.Value = "";
                    BQuanTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }

        }

        int Key = 0;
        protected void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BNameTb.Value = BookList.SelectedRow.Cells[2].Text;
            BAuthCb.SelectedItem.Value = BookList.SelectedRow.Cells[3].Text;
            BCatCb.SelectedItem.Value = BookList.SelectedRow.Cells[4].Text;
            BPriceTb.Value = BookList.SelectedRow.Cells[5].Text;
            BQuanTb.Value = BookList.SelectedRow.Cells[6].Text;

            if (BNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BookList.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || BPriceTb.Value == "" || BQuanTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuthor = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(BPriceTb.Value);
                    int Quantity = Convert.ToInt32(BQuanTb.Value);

                    string Query = "Update BookTbl set BName = '{0}', BAuthor = '{1}', BCategory = '{2}', BPrice = '{3}', BQty = '{4}'  Where BId = {5}";
                    Query = string.Format(Query, BName, BAuthor, BCategory, Price, Quantity, BookList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book Updated!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    BPriceTb.Value = "";
                    BQuanTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || BPriceTb.Value == "" || BQuanTb.Value == "")
                    {
                    ErrMsg.Text = "Select a Book!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuthor = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(BPriceTb.Value);
                    int Quantity = Convert.ToInt32(BQuanTb.Value);

                    string Query = "Delete from BookTbl where BId = {0}";
                    Query = string.Format(Query, BookList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book Deleted!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    BPriceTb.Value = "";
                    BQuanTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}