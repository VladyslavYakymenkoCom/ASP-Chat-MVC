﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Model.Services;
using App.Model.Api;

namespace Some.Controllers
{
    public class HomeController : Controller 
    {
        public HomeController() 
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        
    }
}