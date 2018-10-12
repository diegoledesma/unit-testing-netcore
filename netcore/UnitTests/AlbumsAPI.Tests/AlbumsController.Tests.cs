using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AlbumsAPI.Controllers;
using AlbumsAPI.Repositories;

namespace UnitTests.AlbumsAPI.Tests
{
    [TestClass]
    public class AlbumsControllerTests
	{

        private Mock<IAlbumRepository> _mockRepository;


        [TestInitialize]
        public void Initialize()
        {
            //Setup before running each test
            _mockRepository = new Mock<IAlbumRepository>();
        }

        [TestMethod]
        public void Get_ShouldReturnTheCompleteListOfAlbums()
        {
            var albumList = new List<Album>
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
        public void GetSortedByTitle_ShouldSortAlbumsByTitle()
        {
            var a1 = new Album()
            {
                Title = "zzzzaaabbb",
                CoverHttpPath = "c1"
            };

            var a2 = new Album()
            {
                Title = "aaaaaa",
                CoverHttpPath = "c2"
            };

            var a3 = new Album()
            {
                Title = "111aaaa",
                CoverHttpPath = "c2"
            };

            var albumList = new List<Album> {
                a1, a2, a3
            };

            var expectedList = new List<Album> {
                a3, a2, a1
            };



        }
    }
}
