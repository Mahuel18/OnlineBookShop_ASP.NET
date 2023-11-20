using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookShop.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            string Query = "Select * from CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.DataBind();

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string CatName = CatNameTb.Value;
                    string Description = DescriptionTb.Value;

                    string Query = "Insert into CategoryTbl values('{0}','{1}')";
                    Query = string.Format(Query, CatName, Description);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Inserted!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }

        }

        int Key = 0;
        protected void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoriesList.SelectedRow.Cells[2].Text;
            DescriptionTb.Value = CategoriesList.SelectedRow.Cells[3].Text;
            if (CatNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesList.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!!";
                }
                else
                {
                    string CatName = CatNameTb.Value;
                    string Description = DescriptionTb.Value;

                    string Query = "Update CategoryTbl set CatName = '{0}', CatDescription = '{1}' Where CatId = {2}";
                    Query = string.Format(Query, CatName, Description, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Inserted!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
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
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Select an Category!!!";
                }
                else
                {
                    string CatName = CatNameTb.Value;
                    string Description = DescriptionTb.Value;

                    string Query = "Delete from CategoryTbl where CatId = {0}";
                    Query = string.Format(Query, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Deleted!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}