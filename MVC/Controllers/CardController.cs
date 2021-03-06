﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PokemonTcgSdk;

namespace MVC.Controllers
{
    public class CardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        //public string Welcome(string name, int id = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + id);
        //}


        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }


        public string ById(string id)
        {
            var card = Card.Find<Pokemon>("base4-4");
            var textVersion = card.Card.Name;
            return textVersion;
        }
    }
}