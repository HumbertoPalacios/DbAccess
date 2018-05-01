using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Demo1
{
    //MODEL
    public class MovieInfo
    {
        public string MovieTitle { get; set; }
        public int ReleaseYear { get; set; }
        public List<string> Actors { get; set; }
        public string Rating { get; set; }
    }
}
