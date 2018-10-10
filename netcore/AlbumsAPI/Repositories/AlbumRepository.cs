using System;
using System.Collections.Generic;
using System.Linq;
using Loggers;

namespace AlbumsAPI.Repositories
{
    public class AlbumRepository: IAlbumRepository
    {
        private readonly IConsoleLogger _consoleLogger;
        private readonly IAlbumList _albumList;
        public AlbumRepository(IConsoleLogger consoleLogger, IAlbumList albumList)
        {
            _consoleLogger = consoleLogger;
            _albumList = albumList;
            _albumList.Populate();
        }

        public List<Album> GetAll() {
            return _albumList.GetAll();
        }

        public List<Album> GetStartingWithVowel() {
            return _albumList.GetAlbumsStartingWithVowel();
        }

        public List<Album> GetByTitle(string title) {
            var allAlbums = _albumList.GetAll();
            return allAlbums.Where((Album album) =>
            {
                var albumHasTitle = album.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase);
                return albumHasTitle;
            }).ToList();
        }
    }
}
