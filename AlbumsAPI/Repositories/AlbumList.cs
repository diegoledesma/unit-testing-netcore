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
                Title = "My first album",
                CoverHttpPath = "path here"
            };

            var album2 = new Album()
            {
                Title = "Other title",
                CoverHttpPath = "path here two"
            };

            var album3 = new Album()
            {
                Title = "Fill in the blanks",
                CoverHttpPath = "http:..."
            };

            var album4 = new Album()
            {
                Title = "Something else",
                CoverHttpPath = "https://www.myalbum.com"
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
