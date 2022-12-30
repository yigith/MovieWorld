using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld.Data
{
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(400)]
        public string Title { get; set; } = null!;

        [Precision(3, 1)]
        public decimal Rating { get; set; }

        public int Year { get; set; }


        public List<Genre> Genres { get; set; } = new();
    }
}
