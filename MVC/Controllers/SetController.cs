using System;
using System.Diagnostics;
using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MVC.Controllers
{
    public class SetController : Controller
    {
        // GET: Set
        public ActionResult Index()
        {
            return View();
        }

        public Object Export(string setName)
        {
            ViewBag.Message = "Data for the " + setName;
            if (setName == "UltraPrism")
            {
                var jsonPath = HostingEnvironment.MapPath(@"/App_Data/JsonSets/UltraPrismSetJson.json");
                var jsonObject = ParseJson(jsonPath);

                return jsonObject;
            }
            else
            {
                return Index();
            }
        }

        private static string ParseJson(string pathToJson)
        {
            var jsonPath = pathToJson;
            string allText = "";

            try
            {
                allText = System.IO.File.ReadAllText(jsonPath);
                //o1 = JObject.Parse(allText);
            }
            catch (Exception ex)
            {
                Debug.Write("Could not read json");
            }

            return allText;

        }
    }
}