using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MovieDB.Models.DAL
{
    public class DataServices
    {
        static List<Movie> movieList=new List<Movie>();
        public  int InsertMovie(Movie movie)
        {
            movieList.Add(movie);
            return movieList.Count;
        }
    }
}