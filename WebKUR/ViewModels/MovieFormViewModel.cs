using System.Collections.Generic;
using WebKUR.Models;

namespace WebKUR.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
    }
}