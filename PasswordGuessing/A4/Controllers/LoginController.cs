using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A4.Models;
using A4.Services;

namespace A4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel user)
        {
            Users users = new Users();
            if (users.isValid(user))
            {
                return View("GreenLight", user);
            }
            return View("RedLight", user);
        }
    }
}

