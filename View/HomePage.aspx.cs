using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace balaitani_psd.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        MainDatabaseEntities db = new MainDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = db.Products.ToList();
            rptProducts.DataSource = products;
            rptProducts.DataBind();
        }
    }
}