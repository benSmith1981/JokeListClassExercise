using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokslist
{
    public class Joke
    {
        private string joke;
        private int rating;
        public Joke(int joke, int rating)
        {
            this.joke = joke;
            this.rating = rating;
        }

        public int Rating
        {
            get { return  ; }
            set { rating = value; }
        }
    }
}
