using System;
using System.Data.Entity;

namespace MyMusicStore.Models {
    public class MusicStoreDB : DbContext {
        public MusicStoreDB() : base("name=MusicStore") {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
