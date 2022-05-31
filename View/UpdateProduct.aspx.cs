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
    public partial class UpdateProduct : System.Web.UI.Page
    {
        private Product currentProduct = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string idStr = Request.QueryString["id"];
            int id = 0;
            int.TryParse(idStr, out id);

            if (id == 0)
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }

            currentProduct = ProductController.GetProductById(id);
            if (currentProduct != null)
            {
                if (!IsPostBack)
                {
                    nameTxt.Text = currentProduct.name;
                    priceTxt.Text = currentProduct.price + "";
                    stockTxt.Text = currentProduct.stock + "";
                    descriptionTxt.Text = currentProduct.description;
                }
            }
            else
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }

            if (UserController.GetCurrentUser() == null || UserController.GetCurrentUser().id != currentProduct.User.id)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            int.TryParse(priceTxt.Text, out int price);
            int.TryParse(stockTxt.Text, out int stock);
            string description = descriptionTxt.Text;

            string msg = ProductController.UpdateProduct(currentProduct.id, name, price, stock, description);

            if (msg.Contains("successfully"))
            {
                //Response.Redirect("~/View/LoginPage.aspx");
                errorLbl.CssClass = "text-success";
            }
            errorLbl.Text = msg;
        }
    }
}