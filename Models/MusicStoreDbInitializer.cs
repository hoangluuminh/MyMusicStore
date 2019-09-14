using System;
using System.Data.Entity;
namespace MyMusicStore.Models {
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDB> {
        protected override void Seed(MusicStoreDB context) {
            context.Artists.Add(new Artist { Name = "Lưu Minh Hoàng" });
            context.Albums.Add(new Album {
                Artist = new Artist { Name = "Lu Lu Hồng" },
                Genre = new Genre { Name = "Rốc" },
                Title = "Đá và Lăn EP",
                Price = 949.99m,
            });
            context.Genres.Add(new Genre { Name = "I Đi Em" });
            base.Seed(context);
        }
    }
}
