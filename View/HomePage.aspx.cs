﻿using balaitani_psd.Controller;
using balaitani_psd.Model;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductController.GetAllProducts();
            rptProducts.DataSource = products;
            rptProducts.DataBind();
        }
    }
}