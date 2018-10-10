using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbumsAPI.Repositories
{
    public class AlbumList: IAlbumList
    {

        private List<Album> _albums;
        public AlbumList()
        {

        }

        public void Populate() {
            var album1 = new Album()
            {
                Title = "Hughes / Thrall",
                CoverHttpPath = "https://img.discogs.com/iNbhVbA4VqFkBgWmsvf1GfHnyfY=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-3151392-1445932154-9526.jpeg.jpg"
            };

            var album2 = new Album()
            {
                Title = "Zombie",
                CoverHttpPath = "https://img.discogs.com/oJmbBENnpzf3cJcOOlA1JcUncjM=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-1888854-1250324114.jpeg.jpg"
            };

            var album3 = new Album()
            {
                Title = "Rattle And Hum Vol.1",
                CoverHttpPath = "https://img.discogs.com/0Zxh5HAFinsbLCM3msCn_7wKrLA=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-12638188-1539100768-5354.jpeg.jpg"
            };

            var album4 = new Album()
            {
                Title = "Shivers",
                CoverHttpPath = "https://img.discogs.com/c9iKVGEhxA-wimvYqPzDweC8bIM=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-12638152-1539099990-2223.jpeg.jpg"
            };

            _albums = new List<Album>();
            _albums.Add(album1);
            _albums.Add(album2);
            _albums.Add(album3);
            _albums.Add(album4);
        }

        public List<Album> GetAll() {
            if (_albums == null) {
                throw new InvalidOperationException("Null albums collection");
            }

            return _albums;
        }

        public List<Album> GetAlbumsStartingWithVowel() {
            if (_albums == null)
            {
                throw new InvalidOperationException("Null albums collection");
            }

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            return _albums.Where((Album album) => vowels.Contains(album.Title.ToLower().First())).ToList<Album>();
        }
    }
}
