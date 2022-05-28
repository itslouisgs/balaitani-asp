using balaitani_psd.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace balaitani_psd.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string address = addressTxt.Text;

            string msg = UserController.RegisterUser(name, email, password, address);

            if (msg.Contains("success"))
            {
                errorLbl.CssClass = "text-success";
            }
            errorLbl.Text = msg;
        }
    }
}