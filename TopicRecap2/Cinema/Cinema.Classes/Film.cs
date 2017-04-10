using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Film
    {
        public string Title { get; set; }
        public FilmGenre Genre { get; set; }
        public int Duration { get; set; }
        public bool Is3D { get; set; }
    }
}
