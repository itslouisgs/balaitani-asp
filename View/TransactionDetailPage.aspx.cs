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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private TransactionHeader currentTransaction = null;
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

            //
            currentTransaction = TransactionController.GetTransactionById(id);

            if (currentTransaction)
            {

                nameLbl.Text = currentProduct.name;
                sellerLbl.Text = currentProduct.User.name;
                priceLbl.Text = currentProduct.price + "";
                stockLbl.Text = currentProduct.stock + "";
                descLbl.Text = currentProduct.description;
                productImg.ImageUrl = "~/Asset/" + currentProduct.image;
            }
            else
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }

            if (UserController.GetCurrentUser() == null || UserController.GetCurrentUser().id != currentProduct.User.id)
            {
                editBtn.Visible = false;
                trashBtn.Visible = false;
            }
        }
    }
}