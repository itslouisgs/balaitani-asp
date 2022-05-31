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
    public partial class CartPage : System.Web.UI.Page
    {
        private List<Cart> carts;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetCurrentUser() == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            carts = UserController.GetCurrentUser().Carts.ToList();

            if (carts.Count < 1)
            {
                cartContainer.Visible = false;
            }
            else
            {
                emptyCartErrorContainer.Visible = false;
                rptCarts.DataSource = carts;
                rptCarts.DataBind();
            }
        }

        protected void quantityTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}