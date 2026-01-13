namespace Movie_Schedule_Manager
{
    internal class CinemaMain
    {
        static void Main(string[] args)
        { 
            MovieUtilityImpl obj=new MovieUtilityImpl(3);
            obj.AddMovie("abc","11:30 2:30 6:00");
            obj.AddMovie("xyz","12:30 4:30 8:00");
            obj.AddMovie("pqr","13:30 5:30 9:00");
            obj.DisplayAllMovies();
            obj.SearchMovie("abc");

        }
    }
}
