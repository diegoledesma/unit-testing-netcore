using System.Collections.Generic;
namespace AlbumsAPI.Repositories
{
    public interface IAlbumList
    {
        List<Album> GetAll();
        List<Album> GetAlbumsStartingWithVowel();
        void Populate();
    }
}
