using balaitani_psd.Controller;
using balaitani_psd.Model;
using balaitani_psd.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace balaitani_psd.View
{
    public partial class ProductDetailPage : System.Web.UI.Page
    {
        private Product currentProduct = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string idStr = Request.QueryString["id"];
            int id = 0;
            int.TryParse(idStr, out id);

            if(id == 0)
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }

            currentProduct = ProductRepository.GetProductById(id);
            if(currentProduct != null)
            {
                nameLbl.Text = currentProduct.name;
                sellerLbl.Text = currentProduct.User.name;
                priceLbl.Text = currentProduct.price + "";
                stockLbl.Text = currentProduct.stock + "";
                descLbl.Text = currentProduct.description;
                productImg.ImageUrl = "~/Asset/" + currentProduct.image;
            } else
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }

            if(UserController.GetCurrentUser() == null || UserController.GetCurrentUser().id != currentProduct.User.id)
            {
                editBtn.Visible = false;
                trashBtn.Visible = false;
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProduct.aspx?id=" + currentProduct.id);
        }

        protected void trashBtn_Click(object sender, EventArgs e)
        {
            if (ProductController.DeleteProduct(currentProduct))
                Response.Redirect("HomePage.aspx");
            else
                errorLbl.Text = "Delete error!";
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            if(UserController.GetCurrentUser() == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            int.TryParse(quantityTxt.Text, out int quantity);
            string msg = CartController.AddCart(UserController.GetCurrentUser(), currentProduct, quantity);

            if (msg.Contains("success"))
            {
                errorLbl.CssClass = "text-success";
            }
            errorLbl.Text = msg;
        }
    }
}