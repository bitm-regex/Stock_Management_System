using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagementSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    if(!IsPostBack)
            {
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "CategoryId";
                DropDownList1.DataSource = category.Getcategory;
                DropDownList1.DataBind();

                DropDownList2.DataTextField = "CompanyName";
                DropDownList2.DataValueField = "CompanyId";
                DropDownList2.DataSource = company.Getcompany;
                DropDownList2.DataBind();



            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
             Items aitems = new Items();
             aitems.ItemName = ItemNameTextBox.Text;
             aitems.ReorderLevel = ReorderTextBox.Text;
             ViewState["Items"] = aitems;
            clear();
        }
        public void clear()
        {
            ItemNameTextBox.Text = string.Empty;
           
        }

        protected void ReorderTextBox_TextChanged(object sender, EventArgs e)
        {
            if(ReorderTextBox.Text=="0")
            {
                ReorderTextBox.Text = "";
            }
        }
    }
}