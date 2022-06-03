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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string pageStr = Request.QueryString["page"];
                if (!int.TryParse(pageStr, out int page) || page < 1)
                {
                    page = 1;
                }
                Session["currentPage"] = page;

                (List<Product> products, int totalProductsCount) = ProductController.GetAllProducts(page);

                rptProducts.DataSource = products;
                rptProducts.DataBind();

                int[] pages = Enumerable.Range(1, totalProductsCount / 8 + 1).ToArray();
                pageRpt.DataSource = pages;
                pageRpt.DataBind();

                Session["pageCount"] = pages.Length;
            }
        }

        protected void prevBtn_Click(object sender, EventArgs e)
        {
            int currentPage = (int)Session["currentPage"];
            if(currentPage <= 1)
            {
                return;
            }

            Response.Redirect("HomePage.aspx?page=" + (currentPage - 1));
        }

        protected void nextBtn_Click(object sender, EventArgs e)
        {
            int currentPage = (int)Session["currentPage"];
            int pageCount = (int)Session["pageCount"];

            if (currentPage >= pageCount)
            {
                return;
            }

            Response.Redirect("HomePage.aspx?page=" + (currentPage + 1));
        }

        protected bool IsActivePage(int page)
        {
            return (Session["currentPage"] != null && page == (int)Session["currentPage"]);
        }
    }
}