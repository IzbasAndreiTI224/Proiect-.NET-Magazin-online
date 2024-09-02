using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.Responces;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Models.User;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {


        private readonly ISession _session;

        public LoginController()

        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();


        }

        public ActionResult LogIn()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(UserLogin login)
        {
            if (ModelState.IsValid)//daca datele introduse sunt corecte
            {
                var data = Mapper.Map<ULoginData>(login);

                data.Ip = Request.UserHostAddress;//ia ip si data cand te loghezi
                data.LoginTime = DateTime.Now;

                var userLogin = _session.UserLoginAction(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Email);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Product");//te duci la pagina principala
                }
                else
                {
                    ModelState.AddModelError("", userLogin.ActionStatusMsg);
                    return View();
                }
            }
            return View();
        }
    }
}