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
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetCurrentUser() != null)
            {
                registerLink.Visible = false;
                loginLink.Visible = false;

                User user = UserController.GetCurrentUser();

                userNameLbl.Text = user.name;
            } else
            {
                dropdownDiv.Visible = false;
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            UserController.Logout();
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}