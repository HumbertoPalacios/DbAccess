using OOPDEMO.Demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Demo2
{
    public class CollectionDemo<T>
    {

        public class BuildMovieData
        {
            public List<MovieInfo> Movies()
            {
                return new List<MovieInfo>
                {
                    new MovieInfo {MovieTitle="Looper"},
                    new MovieInfo {MovieTitle="Back to the Future"},
                    new MovieInfo {MovieTitle="Blast from the past"},
                    new MovieInfo {MovieTitle="Pulp Fiction"},
                    new MovieInfo {MovieTitle="Big Fish"}
                };
            }
        }


        public class MovieService
        {
            Dictionary<string, MovieInfo> movieDb = new Dictionary<string, MovieInfo>();
            public MovieService()
            {
                BuildMovieData bmd = new BuildMovieData();
                foreach(MovieInfo mi in bmd.Movies())
                {
                    movieDb.Add(mi.MovieTitle, mi);
                }
            }
        

        public MovieInfo GetByTitle(string title)
        {
            if (movieDb.ContainsKey(title))
                {
                    return movieDb[title];
                }
                return null;
        }
            public void AddMovie(MovieInfo mi)
            {
                if (!movieDb.ContainsKey(mi.MovieTitle))
                    movieDb.Add(mi.MovieTitle, mi);
            }
    }





        public void Collection1()
        {
            List<string> list = new List<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");

            List<T> list2 = new List<T>();
        }

        /*
         Create a NEW class that has a dictionary of 5 movies using the MovieInfo class 
         Add a method in the class to lookup movie by title
         Add a method to add a new movie to the dictionary
         */

        public void Collection2()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");

            string item2 = dictionary[2];
            if(dictionary.ContainsKey(2))
            {
                //extract the value
                string itm2 = dictionary[2];
            }
        }

    }

    public class Tester
    {
        private class MyObject { }

        CollectionDemo<int[]> cd = new CollectionDemo<int[]>();
    }
}
