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
    public partial class TransactionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetCurrentUser() == null)
            {
                Response.Redirect("LoginPage.aspx");
                return;
            }

            List<TransactionHeader> transactions = UserController.GetCurrentUser().TransactionHeaders.ToList();
            listTransactions.DataSource = transactions;
            listTransactions.DataBind();
        }
    }
}