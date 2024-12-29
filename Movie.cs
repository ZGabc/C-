using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitile, string aDirector, string aRating)
        {
            this.title = aTitile;   
            this.director = aDirector;
            this.rating = aRating;
        }

        public string Rating { 
            get { return rating; } 
            set {
                if (value == "3,5/5" || value == "1" || value == "2")
                {
                    rating = value;
                }
                else
                {
                    rating = "abc";
                }
            }
        } 
    }
}
