using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKUR.Models;

namespace WebKUR.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

    }
}