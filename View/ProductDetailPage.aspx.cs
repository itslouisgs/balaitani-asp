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

            Product product = ProductRepository.GetProductById(id);
            if(product != null)
            {
                nameLbl.Text = product.name;
            } else
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }
        }
    }
}