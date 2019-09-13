using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionWorld.Models;
namespace FashionWorld.Controllers
{
    public class ShopController : Controller
    {
        FashionWorldEntities db = new FashionWorldEntities();
        Algos algos = new Algos();

        public ActionResult Product_Detail(int id)
        {
            var result2 = new List<FashionWorld.Models.products>();
            var result = db.products.SqlQuery("select * from products where ID = @a;", new SqlParameter("@a",id)).SingleOrDefault();
            string[] str = algos.category(result.product_category_tree);

            if (result.product_category_tree.Contains("Men's Clothing"))
            {

                result2 = db.products.SqlQuery("select distinct * from products where product_category_tree like '%' + @a + '%' and product_category_tree like '%' + @b + '%' and not product_category_tree like '%' + 'Women''s Clothing' + '%'", new SqlParameter("@a", str[2]), new SqlParameter("@b", str[3])).ToList();
            }
            else if (result.product_category_tree.Contains("Women's Clothing"))
            {
                result2 = db.products.SqlQuery("select distinct * from products where product_category_tree like '%' + @a + '%' and product_category_tree like '%' + @b + '%' ", new SqlParameter("@a", str[2]), new SqlParameter("@b", str[3])).ToList();
            }

            var obj = new FashionWorld.Models.ProductsListViewModel();
            obj.productMain = result;
            obj.productRelated = result2;
            return View(obj);
        }
        [HttpGet]
        public ActionResult Products(string id,string type)
        {
            var res = new List<FashionWorld.Models.products>();
            if(type == "Men's Clothing")
            {
                res = db.products.SqlQuery("select distinct * from products where product_category_tree like '%' + @a + '%' and product_category_tree like '%' + @b + '%' and not product_category_tree like '%' + 'Women''s Clothing' + '%'", new SqlParameter("@a", id), new SqlParameter("@b", type)).ToList();
            }
            else
            {
                res = db.products.SqlQuery("select distinct * from products where product_category_tree like '%' + @a + '%' and product_category_tree like '%' + @b + '%' ", new SqlParameter("@a", id), new SqlParameter("@b", type)).ToList();
            }
             
            if(res.Count() > 0)
            {
                return View(res);
            }
            else
            {
                return Content("failed");
            }
        }

    }
}