using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusicStore.Models;
using System.Net;

namespace MyMusicStore.Controllers {
    public class OldStoreManagerController : Controller {
        private MusicStoreDB db = new MusicStoreDB();
        public ActionResult Index() {
            var albums = from album in db.Albums
                         select album;
            var albumsList = albums.ToList();
            return View(albumsList);
        }
        public ActionResult Edit(int? id) {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Album album = db.Albums.Find(id);
            if (album == null)
                return HttpNotFound();
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", album.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", album.GenreId);
            return View(album);
        }
    }
}
