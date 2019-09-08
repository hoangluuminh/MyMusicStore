using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMusicStore.Controllers {
    public class StoreController : Controller {
        public string Index() {
            //return View();
            return "<p style=\"font-weight: bold\">Hello world</p>";
        }
        public string Browse(string genre) {
            //return View();
            return HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
        }
        public string Details(string id = "") {
            //return View();
            Console.WriteLine("id: " + id);
            return HttpUtility.HtmlEncode("Store.Details, ID = " + id);
        }
    }
}
