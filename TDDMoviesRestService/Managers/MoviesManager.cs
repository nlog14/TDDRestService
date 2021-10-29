using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TDDMoviesRestService.Managers
{
    public class MoviesManager
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie("Dune", "R.12", "120", new DateTime(2021, 11, 12)),
            new Movie("While You Were Sleeping", "R.20", "120", new DateTime(2021, 11, 12)),
            new Movie("Halloween", "R.05", "120", new DateTime(2021, 10, 13))

        };


        public List<Movie> GetMovies()
        {
            return movies;
        }

        //public int GetTotalNumberOfMovies()
        //{
        //    var TotalMovies = movies;
        //    return TotalMovies.Count();
        //}

        //public List<Movie> MoviesAvailableByDate(DateTime DateAndTimeSearchCriteria)
        //{
        //    var moviesByDate = movies.FindAll(m => m.Title.Equals(DateAndTimeSearchCriteria));
        //    return moviesByDate;
        //}


        public Movie AddNewMovie(Movie newMovie)
        {
            movies.Add(newMovie);
            return newMovie;
        }


        public Movie DeleteMovie(string title)
        {
            var movieToDelete = movies.Find(m => m.Title.Equals(title));
            movies.Remove(movieToDelete);
            return movieToDelete;
        }



    }
}
