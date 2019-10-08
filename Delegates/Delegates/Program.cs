using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = "Frozen";

            var moviePlayer = new MoviePlayer { CurrentMovie = movie };

            MoviePlayer.MovieFinishedHandler handler = PrintMovieOver;

            moviePlayer.MovieFinished += handler;
            moviePlayer.MovieFinished += handler;
            //moviePlayer.MovieFinished -= handler;


            moviePlayer.PlayMovie();
        }

        static void PrintMovieOver()
        {
            Console.WriteLine("Movie finished");
        }
    }
}
