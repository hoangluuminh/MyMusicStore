using System;
using System.Collections.Generic;

namespace MyMusicStore.Models {
    public class Artist {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
