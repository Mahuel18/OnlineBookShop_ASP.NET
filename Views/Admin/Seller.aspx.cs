using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSellers();
        }
        private void ShowSellers()
        {
            string Query = "Select * from SellerTbl";
            SellerList.DataSource = Con.GetData(Query);
            SellerList.DataBind();

        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string Email = EmailTb.Value;
                    string Phone = PhoneTb.Value;
                    string Address = AddressTb.Value;

                    string Query = "Insert into SellerTbl values('{0}','{1}', '{2}', '{3}')";
                    Query = string.Format(Query, SName, Email, Phone, Address);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Inserted!!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }

        }

        int Key = 0;
        protected void SellerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SNameTb.Value = SellerList.SelectedRow.Cells[2].Text;
            EmailTb.Value = SellerList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = SellerList.SelectedRow.Cells[4].Text;
            AddressTb.Value = SellerList.SelectedRow.Cells[5].Text;

            if (SNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellerList.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string Email = EmailTb.Value;
                    string Phone = PhoneTb.Value;
                    string Address = AddressTb.Value;

                    string Query = "Update CategoryTbl set SellName = '{0}', SellEmail = '{1}', SellPhone = '{2}', SellAddress = '{3}'  Where SellId = {4}";
                    Query = string.Format(Query, SName, Email, Phone, Address, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Updated!!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";
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
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Select a Seller!!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string Email = EmailTb.Value;
                    string Phone = PhoneTb.Value;
                    string Address = AddressTb.Value;

                    string Query = "Delete from CategoryTbl where CatId = {0}";
                    Query = string.Format(Query, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Deleted!!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}