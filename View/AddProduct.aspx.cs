using balaitani_psd.Controller;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace balaitani_psd.View
{
    public partial class AddProduct : System.Web.UI.Page
    {
        private User currentUser = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                currentUser = (User)Session["user"];
            }
            else
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            int.TryParse(priceTxt.Text, out int price);
            int.TryParse(stockTxt.Text, out int stock);
            string description = descriptionTxt.Text;
            //string image = imageFile.FileName;

            string msg = ProductController.AddProduct(name, price, stock, "", description, currentUser.id);

            if (msg.Contains("successfully"))
            {
                errorLbl.CssClass = "text-success";
            }
            errorLbl.Text = msg;
        }
    }
}