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
            if (Session["user"] != null)
            {
                registerLink.Visible = false;
                loginLink.Visible = false;

                User user = (User)Session["user"];

                userNameLbl.Text = user.name;
            } else
            {
                dropdownDiv.Visible = false;
            }
        }
    }
}