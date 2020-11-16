using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCRM.Business.Abstract;
using BasicCRM.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BasicCRM.WebUI.Controllers
{
    public class LoginsController : Controller
    {
        private IUserService _userService;

        public LoginsController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost, ActionName("UserLogin")]
        public IActionResult UserLogin(User user)
        {
            var result = _userService.Login(user);

            if (result.Success)
            {
                ViewData["UserName"] = user.UserName;
                return RedirectToAction("Index", "Customers");
            }
            return BadRequest(result.Message);
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Logins");
        }
    }
}
