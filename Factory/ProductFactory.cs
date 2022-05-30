using balaitani_psd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace balaitani_psd.Factory
{
    public class ProductFactory
    {
        public static Product Create(string name, int price, int stock, FileUpload imageFile, string description, int seller_id)
        {
            var file = imageFile.PostedFile;
            var paths = "~/Asset/images/" + DateTime.Now.ToString("yyyyMMdd_HHmmssffff") + "_" + file.FileName;
            var filePath = HttpContext.Current.Server.MapPath(paths);
            file.SaveAs(filePath);
            Product newProduct = new Product
            {
                name = name,
                price = price,
                stock = stock,
                description = description,
                image = paths.Replace("~/Asset/", ""),
                seller_id = seller_id
            };

            return newProduct;
        }
    }
}