using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcformsauthentication.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int Runtime { get; set; }
    }


    //两个model 使用同一个dbcontext,也可分开
    public class MovieDB : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}