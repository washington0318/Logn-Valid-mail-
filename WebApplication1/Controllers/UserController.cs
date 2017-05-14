using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Logn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Logn(LogonViewModel padeDate)
        {
            if (padeDate.Account != null &&
                padeDate.Password != null
                &&
                padeDate.Message != null
                )
            {
                padeDate.Message =
                    $"您使用{padeDate.Account}登入成功。";
                return RedirectToAction("Logoned");//登入之後開啟另一個分頁

            }
            else
            {
                padeDate.Message =
                 $"您使用{padeDate.Account}登入失敗。";
            }
           
            return View(padeDate);
        }
        public ActionResult Logoned()
        {
            return View();
        }


       }
    
}