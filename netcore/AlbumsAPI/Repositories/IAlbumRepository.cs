using System.Collections.Generic;

namespace AlbumsAPI.Repositories
{
    public interface IAlbumRepository
    {
        //TODO signatures here
        List<Album> GetAll();
        List<Album> GetByTitle(string title);
        List<Album> GetStartingWithVowel();
    }
}
