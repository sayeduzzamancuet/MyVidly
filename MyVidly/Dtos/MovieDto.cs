using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string MovieName { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }
        public int StockAvailable { get; set; }
    }
}