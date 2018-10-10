using System;
namespace AlbumsAPI.Repositories
{
    public class Album
    {
        private string _title;
        private string _coverHttpPath;

        public Album()
        {

        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string CoverHttpPath
        {
            get => _coverHttpPath;
            set => _coverHttpPath = value;
        }

        public bool IsCoverValid() {
            return Uri.IsWellFormedUriString(_coverHttpPath, UriKind.Absolute);
        }
    }
}
