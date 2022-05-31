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

            currentTransaction = TransactionController.GetTransactionById(id);

            if (currentTransaction != null)
            {
                tDate.Text = currentTransaction.transaction_date + "";
                tStatus.Text = currentTransaction.status;
                tShipping.Text = currentTransaction.Shipping.name;
                tPaymentMethod.Text = currentTransaction.PaymentMethod.name;
                tShippingFee.Text = currentTransaction.Shipping.price + "";

                tDetails.DataSource = currentTransaction.TransactionDetails;
                tDetails.DataBind();

                int total = 0;

                foreach (var item in currentTransaction.TransactionDetails)
                {
                    total += item.Product.price * item.quantity;
                }

                tTotal.Text = total + "";
                tNetTotal.Text = (total + currentTransaction.Shipping.price).ToString();
            }
            else
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }
        }
    }
}