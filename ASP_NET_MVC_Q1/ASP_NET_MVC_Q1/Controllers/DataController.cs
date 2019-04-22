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
            UserModel userModel = new UserModel();
            userModel.name = user.name;
            userModel.email = user.email;
            userModel.phone = user.phone;

            string writefile = "Name:" + '\n' + userModel.name + "Phone:" + userModel.phone + "\n" + "Email:" + userModel.email;
            string sourceFile = Server.MapPath("~/App_Data/" + "suec.txt");
            System.IO.File.WriteAllText(sourceFile, writefile);

            return View(userModel);
        }
    }
}