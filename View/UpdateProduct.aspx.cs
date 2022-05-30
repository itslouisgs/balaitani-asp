using balaitani_psd.Model;
using balaitani_psd.Repository;
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

            currentProduct = ProductRepository.GetProductById(id);
            if (currentProduct != null)
            {
                nameTxt.Text = currentProduct.name;
                priceTxt.Text = currentProduct.price + "";
                stockTxt.Text = currentProduct.stock + "";
                descriptionTxt.Text = currentProduct.description;
            }
            else
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}