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
        public DateTime Date_Time { get; set; }


        public Movie(string title, string bio_room, string duration, DateTime date_time)
        {
            Title = title;
            Bio_Room = bio_room;
            Duration = duration;
            Date_Time = date_time;
        }

    }
}
