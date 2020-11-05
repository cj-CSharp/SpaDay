﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("user/add")]
        public IActionResult SubmitAddUserForm(User aUser, string passwordCheck)
        {
            if(aUser.Password == passwordCheck)
            {
                ViewBag.currentUser = aUser;
                return View("Index");
            }
            return View("Add");
        }
    }
}
