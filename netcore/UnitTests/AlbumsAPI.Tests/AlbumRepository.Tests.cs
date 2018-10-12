using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AlbumsAPI.Repositories;
using Loggers;

namespace UnitTests.AlbumsAPI.Tests
{
    [TestClass]
    public class AlbumRepositoryTests
    {
        private List<Album> _albums;

        [TestInitialize]
        public void Initialize()
        {

        }

        public AlbumRepositoryTests()
        {
            _albums = new List<Album>
            {
                new Album()
                {
                    Title = "t1",
                    CoverHttpPath = "c1"
                },

                new Album()
                {
                    Title = "t2",
                    CoverHttpPath = "c2"
                }
            };
        }

        [TestMethod]
        public void GetAll_ShouldReturnTheCompleteListOfAlbums() {

        }

        [TestMethod]
        public void GetStartingWithVowel_ShouldReturnAlbumsStartingWithAVowel()
        {

        }

        [TestMethod]
        public void GetStartingWithVowel_ShouldThrowInvalidOperationException()
        {

        }

        [TestMethod]
        public void GetByTitle_ShouldIgnoreCase()
        {

        }




    }
}
