using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusicStore.Models;

namespace MyMusicStore.Controllers {
    public class StoreManagerController : Controller {
        private MusicStoreDB db = new MusicStoreDB();
        public ActionResult Index() {
            var albums = from album in db.Albums
                         select album;
            var albumsList = albums.ToList();
            return View(albumsList);
        }
    }
}
