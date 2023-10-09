using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Websitebanhangdientu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ShoppingCart()
        {
            return View();
        }
        public ActionResult Detail_Products()
        {
            return View();
        }
        public ActionResult Product_PC()
        {
            return View();
        }
        public ActionResult Product_MousePads()
        {
            return View();
        }
        public ActionResult Product_Speakers()
        {
            return View();
        }
        public ActionResult Product_Chairs()
        {
            return View();
        }
        public ActionResult Product_Tables()
        {
            return View();
        }
        public ActionResult Product_Mics()
        {
            return View();
        }
        public ActionResult Product_Keyboard()
        {
            return View();
        }
        public ActionResult Product_Mouse()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}