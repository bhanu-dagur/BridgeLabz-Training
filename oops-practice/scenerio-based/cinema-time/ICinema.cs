using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Schedule_Manager
{
    internal interface ICinema
    {
        void AddMovie(String title, String time);
        void SearchMovie(String title);
        void DisplayAllMovies();
    }
}
