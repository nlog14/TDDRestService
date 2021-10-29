using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDDMoviesRestService
{
    public class Movie
    {
        public string Title { get; set; }
        public string Bio_Room { get; set; }
        public string Duration { get; set; }
        public List<DateTime> MovieDateTime { get; set; }


        public Movie(string title, string bio_room, string duration, List<DateTime> movie_date_time)
        {
            Title = title;
            Bio_Room = bio_room;
            Duration = duration;
            MovieDateTime = movie_date_time;
        }

    }
}
