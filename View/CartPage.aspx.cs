using balaitani_psd.Controller;
using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace balaitani_psd.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        private List<Cart> carts;
        private List<PaymentMethod> paymentMethods;
        private List<Shipping> shippings;
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
                int total = 0;
                foreach(Cart c in carts)
                {
                    total += c.Product.price * c.quantity;
                }
                subTotalLbl.Text = Convert.ToDecimal(total).ToString("#,##0.00");
                taxLbl.Text = Convert.ToDecimal(0.1 * total).ToString("#,##0.00");
                totalLbl.Text = Convert.ToDecimal(1.1 * total).ToString("#,##0.00");

                emptyCartErrorContainer.Visible = false;
                rptCarts.DataSource = carts;
                rptCarts.DataBind();

                shippings = ShippingController.GetAllShippings();

                var dataSource = from x in shippings
                                 select new
                                 {
                                     x.id,
                                     x.name,
                                     DisplayField = String.Format("{0} (Rp{1})", x.name, x.price)
                                 };
                shippingServiceSelect.DataTextField = "DisplayField";
                shippingServiceSelect.DataValueField = "id";
                shippingServiceSelect.DataSource = dataSource;

                shippingServiceSelect.DataBind();
                shippingServiceSelect.Items.Insert(0, new ListItem("Choose shipping service", "0"));

                paymentMethods = PaymentMethodController.GetAllPaymentMethods();
                paymentMethodSelect.DataTextField = "name";
                paymentMethodSelect.DataValueField = "id";
                paymentMethodSelect.DataSource = paymentMethods;

                paymentMethodSelect.DataBind();
                paymentMethodSelect.Items.Insert(0, new ListItem("Choose payment method", "0"));
            }
        }

        protected void rptCarts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "deleteCart")
            {
                string idStr = e.CommandArgument.ToString();
                int.TryParse(idStr, out int id);
                Cart cart = carts.Where(c => c.product_id == id).FirstOrDefault();

                CartController.DeleteCart(cart);
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void shippingServiceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void paymentMethodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //protected void quantityTxt_TextChanged(object sender, EventArgs e)
        //{
        //    Debug.WriteLine("masuk");
        //    TextBox txt = (TextBox)sender;
        //    RepeaterItem item = (RepeaterItem)txt.NamingContainer;
        //    Button btn = (Button)item.FindControl("deleteBtn");
        //    string idStr = btn.CommandArgument.ToString();
        //    int.TryParse(idStr, out int id);
        //    Cart cart = carts.Where(c => c.product_id == id).FirstOrDefault();

        //    int.TryParse(txt.Text, out int quantity);

        //    CartController.UpdateCart(cart, quantity);
        //}
    }
}