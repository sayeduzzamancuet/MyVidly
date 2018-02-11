using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.ViewModel
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}