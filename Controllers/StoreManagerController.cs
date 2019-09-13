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
            var genres = from genre in db.Genres
                         select genre;
            var genresList = genres.ToList();
            return View(genresList);
        }
    }
}
