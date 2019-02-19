﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmReviewWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our Film Review Website application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our Film Review Website contact page.";

            return View();
        }
    }
}