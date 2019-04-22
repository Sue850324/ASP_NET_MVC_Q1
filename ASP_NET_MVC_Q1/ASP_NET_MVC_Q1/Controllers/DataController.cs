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
    public class DataController : Controller
    {
        public ActionResult Save(UserModel user)
        {    
            string writefile = "Name:" + '\n' + user.name + "Phone:" + user.phone + "\n" + "Email:" + user.email;
            string sourceFile = Server.MapPath("~/App_Data/" + "suec.txt");
            System.IO.File.WriteAllText(sourceFile, writefile);
            return View(user);
        }
    }
}