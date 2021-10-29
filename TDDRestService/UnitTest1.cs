using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using NUnit.Framework.Api;
using TDDMoviesRestService;
using TDDMoviesRestService.Controllers;

namespace TDDRestService
{
    public class Tests
    {
        public MoviesController MC = new MoviesController();

        public void TestSetup()
        {
            MC = new MoviesController(); 
            List<DateTime> DunesDateTimes = new List<DateTime>()
            {
                new DateTime(2021, 11, 12, 21, 00, 00),
                new DateTime(2021, 11, 13, 19, 00, 00),
                new DateTime(2021, 11, 14, 22, 00, 00)
            };
            Movie m1 = new Movie("Dunes", "R.12", "120", DunesDateTimes);

            List<DateTime>WYWSDateTimes = new List<DateTime>()
            {
                new DateTime(2021, 11, 20, 13, 00, 00),
                new DateTime(2021, 11, 24, 14, 00, 00),
                new DateTime(2021, 11, 30, 15, 00, 00)
            };
            Movie m2 = new Movie("While You Were Sleeping", "R.20", "120", WYWSDateTimes);

            List<DateTime> HalloweeDateTimes = new List<DateTime>()
            {
                new DateTime(2021, 12, 20, 13, 00, 00),
                new DateTime(2021, 10, 30, 14, 00, 00),
                new DateTime(2021, 10, 31, 15, 00, 00)
            };
            Movie m3 = new Movie("Halloween", "R.05", "120", HalloweeDateTimes);

            MC.Post(m1);
            MC.Post(m2);
            MC.Post(m3);
        }

        [Test]
        public void GetTotalNumberOfMovies()
        {
            //Arrange
            
            TestSetup();

            //Act

            int numberOfMovies = MC.GetTotalNumberOfMovies();

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
            TestSetup();

            //Act
            int beforeCount = MC.GetTotalNumberOfMovies();
            MC.Post(new Movie("Toy Story", "R.40", "120", new List<DateTime>(){ new DateTime(2021, 12, 01 , 10, 00, 00), new DateTime(2021, 12, 20, 12, 00, 00), new DateTime(2021, 12, 26, 19, 30, 00) }));
            int afterCount = MC.GetTotalNumberOfMovies();

            //Assert
            Assert.AreEqual(3, beforeCount);
            Assert.AreEqual(beforeCount + 1, afterCount);
        }

        [Test]
        public void DeleteMovie()
        {
            //Arrange
            TestSetup();

            //Act
            int beforeCount = MC.GetTotalNumberOfMovies();
            MC.Delete("Dunes");
            int afterCount = MC.GetTotalNumberOfMovies();

            //Assert
            Assert.AreEqual(3, beforeCount);
            Assert.AreEqual(2, afterCount);
        }


    }
}