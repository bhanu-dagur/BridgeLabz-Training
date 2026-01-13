using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Schedule_Manager
{
    
    internal class MovieUtilityImpl: ICinema
    {
        private Movie[] Movies;
        int count;

        public MovieUtilityImpl (int noOfMovie)
        {
            Movies = new Movie[noOfMovie];
            count = 0;
        }
        public void AddMovie(string title, string time)
        {
            Movie movie = new Movie(title,time);

            if (count == Movies.Length)
            {
                Console.WriteLine("No more movie are added");
                return;
            }
            for (int i = 0; i < Movies.Length; i++)
            {
                if (Movies[i] == null)
                {
                    Movies[i] = movie;
                    count++;
                    return;
                }
            }
        }
        public void SearchMovie(string title)
        {
            for (int i = 0; i < Movies.Length; i++) {
                if (Movies[i].getMovieTitle() == title)
                {
                    Console.WriteLine(Movies[i]);
                }
            }
        }
        public void DisplayAllMovies()
        {
            foreach (Movie movie in Movies)
            {
                if (movie != null)
                {
                    Console.WriteLine(movie.getMovieTitle());
                    string[] time = movie.getShowTime().Split (" ");
                    for (int i = 0; i < time.Length; i++)
                    {
                        Console.WriteLine(time[i]);
                    }
                }
            }
        }

    }
}
