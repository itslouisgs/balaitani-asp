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
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserRepository.GetCurrentUser() != null)
            {
                registerLink.Visible = false;
                loginLink.Visible = false;

                User user = UserRepository.GetCurrentUser();

                userNameLbl.Text = user.name;
            } else
            {
                dropdownDiv.Visible = false;
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            UserRepository.Logout();
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}