using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Demo1
{
    //The class = the blue print. The Object is an actual thing that is built based on the 'blue print'
    //(like the house). An instance is a virtual copy (but not a real copy) of the object.
    public class Movie
    {

        public MovieInfo MovieObject { get;  private set; } //property

        public Movie(MovieInfo movieInfo)
        {
            //constructor with one input
            MovieObject = movieInfo;
        }

        public string MovieTitlePlus(string extraInfo)
        {
            return $"{ MovieObject.MovieTitle } { MovieObject.ReleaseYear } { extraInfo}";
        }
        public int GetReleaseYear()
        {
            return MovieObject.ReleaseYear;
        }
    }
    public class ClassTester
    {
        Movie _movie2= new Movie(new MovieInfo
        {
            MovieTitle = "Tropic Thunder",
            ReleaseYear = 2008
        });

        public void Test()
        {
            Console.WriteLine(_movie2.MovieTitlePlus("Something extra"));
        }

    }
}

