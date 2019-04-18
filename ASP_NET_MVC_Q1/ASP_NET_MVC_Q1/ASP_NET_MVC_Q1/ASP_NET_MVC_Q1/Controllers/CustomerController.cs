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
        [HttpPost]
        public ActionResult Detail(UserModel user)
        {
            if (ModelState.IsValid)
            {
                Session["Name"]  = user.name;
                Session["Phone"]  = user.phone;
                Session["Email"]  = user.email;
                return RedirectToAction("Check");
            }
            return View();               
        }

        public ActionResult Check()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Check(FileModel file)
        {
            if (ModelState.IsValid)
            {
                Session["FileName"] = file.fileName;
                string writefile = "Name:" + '\n' + Session["Name"] + "Phone:" + Session["Phone"] + "\n" + "Email:" + Session["Email"];
                string sourceFile = Server.MapPath("~/App_Data/"+ Session["FileName"] + ".txt") ;

                System.IO.File.WriteAllText(sourceFile, writefile);

                return RedirectToAction("Save");
            }
            return View();
        }

        public ActionResult Save(UserModel param)
        {
            
            return View();
        }
    }
}