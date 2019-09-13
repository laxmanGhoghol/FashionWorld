using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionWorld.Models;

namespace FashionWorld.Controllers
{
    public class ConsumersController : Controller
    {
        FashionWorldEntities db = new FashionWorldEntities();

        //#################################################### -Customer Resgistration- #################################################################################
        // GET: Customer
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register(customers cust)
        {
            try
            {

                customers cs = new customers();
                cs.FirstName = cust.FirstName;
                cs.LastName = cust.LastName;
                cs.Gender = cust.Gender;
                cs.Email = cust.Email;
                cs.Mobile = cust.Mobile;
                cs.UPass = cust.UPass;
                cs.IsVerified = "No";
                db.customers.Add(cs);
                db.SaveChanges();
            }
            catch(Exception exe)
            {
                throw exe;
            }
            return RedirectToAction("Index", "Home");
        }
//##########################################################-Consumer Address-#################################################################################
        //http Get: AddAddress
        public ActionResult AddAdress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAddress(addresses addr)
        {
            try
            {
                List<object> list = new List<object>();
                list.Add(addr.CustID);
                list.Add(addr.Add_Type);
                list.Add(addr.del_Address);

                return View();
            }
            catch
            {
                return View();
            }
        }

        //##########################################################-Log In/Sign In-###############################################################################
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(string uid,string pass)
        {
            return RedirectToAction("Index", "Home");
        }

        //##########################################################-Consumer Menu-Edit-###############################################################################

        public ActionResult Profile_Menu(int id)
        {
            return View();
        }
        public ActionResult Profile_Menu(string str)
        {
            return View();
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Orders(int id)
        {
            return View();
        }
    }
}