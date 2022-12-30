using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld.Data
{
    public class Genre
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; } = null!;


        public List<Movie> Movies { get; set; } = new();
    }
}
