using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieDB.Models.DAL;

namespace MovieDB.Models
{
    public class Movie
    {
        int id;
        string title;
        string description;
        ArrayList genre;
        DateTime releaseDate;
        string img;
        double score;

        public Movie(int id,string title,string description, ArrayList genre,DateTime releaseDate, string img,double score)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.genre = genre;
            this.releaseDate = releaseDate;
            this.img = img; 
            this.score = score; 
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public ArrayList Genre { get => genre; set => genre = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Img { get => img; set => img = value; }
        public double Score { get => score; set => score = value; }


        public int Insert()
        {
            DataServices ds = new DataServices();
            ds.InsertMovie(this);
            return 1;
        }

    }
}