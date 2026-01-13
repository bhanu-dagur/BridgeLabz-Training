using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Schedule_Manager
{
    internal class Movie
    {
        private string MovieTitle;
        private string ShowTime;

        public Movie(string movieTitle ,string showTime)
        {
            MovieTitle = movieTitle;
            ShowTime = showTime;

        }
        public string getShowTime()
        {
            return ShowTime; 
        }
        public string getMovieTitle()
        {
            return MovieTitle;
        }
        public override string ToString()
        {
            return MovieTitle + " " + ShowTime;
        }
    }
}
