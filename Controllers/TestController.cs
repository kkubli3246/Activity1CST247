﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index()
        {
            return @"<b>Hello World as a string from Index!</b>";
        }

        // GET: /Test/Play
        [HttpGet]
        public string Play()
        {
            //return string as a view

            return @"<b>Hello World as a string from Play!</b>";
        }

        //GET: /Test/TestView
        [HttpGet]
        public ActionResult TestView()
        {

            return View();
        }
    }
}