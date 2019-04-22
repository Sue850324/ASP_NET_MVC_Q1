using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_NET_MVC_Q1.Models;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace ASP_NET_MVC_Q1.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Detail()
        {       
                return View();          
        }

        public ActionResult Check()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Check(UserModel user)
        {

            if(ModelState.IsValid)
            {
                return View(user);
            }

            return View("Detail");
           
        }


    }
}