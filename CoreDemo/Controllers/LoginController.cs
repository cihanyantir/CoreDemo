﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    { [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var values=c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail &&
             x.WriterPassword == p.WriterPassword);
            if (values!=null){
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name,p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "b");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
             return RedirectToAction("Index", "Dashboard"); }
            else
            {
                return View();
            }

        }

    }
    
}
//{
//            Context c = new Context();
//            var values = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail &&
//              x.WriterPassword == p.WriterPassword);
//            if(values!=null)
//            {
//                HttpContext.Session.SetString("username", p.WriterMail);
//                return RedirectToAction("Index", "Writer");
//            }
//            return View();
//        }