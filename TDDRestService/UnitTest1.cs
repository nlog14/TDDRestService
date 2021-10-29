using System;
using NUnit.Framework;
using NUnit.Framework.Api;
using TDDMoviesRestService;
using TDDMoviesRestService.Controllers;

namespace TDDRestService
{
    public class Tests
    {

        public void TestSetup()
        {

        }
        [Test]
        public void GetTotalNumberOfMovies()
        {
            //Arrange
            var movies = new MoviesController();

            //Act
            int numberOfMovies = movies.GetTotalNumberOfMovies();

            //Assert
            Assert.AreEqual(3, numberOfMovies);
        }

        //[Test]
        //public void MovieNotAvailableOnASpecificDay()
        //{
        //    //Arrange
        //    var movies = new MoviesController();

        //    //Act
        //    bool movieAvailable = movies.LookUp;

        //    //Assert
        //    Assert.AreEqual(null, movieAvailable);
        //}

        [Test]
        public void AddMovie()
        {
            //Arrange
            var movies = new MoviesController();

            //Act
            int beforeCount = movies.GetTotalNumberOfMovies();
            movies.Post(new Movie("Toy Story", "R.40", "120", new DateTime(2021, 11, 12)));
            int afterCount = movies.GetTotalNumberOfMovies();

            //Assert
            Assert.AreEqual(3, beforeCount);
            Assert.AreEqual(beforeCount + 1, afterCount);
        }

        [Test]
        public void DeleteMovie()
        {
            //Arrange
            var movies = new MoviesController();

            //Act
            int beforeCount = movies.GetTotalNumberOfMovies();
            movies.Delete("Dune");
            int afterCount = movies.GetTotalNumberOfMovies();

            //Assert
            Assert.AreEqual(4, beforeCount);
            Assert.AreEqual(3, afterCount);
        }


    }
}