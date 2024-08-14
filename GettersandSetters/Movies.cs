using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersandSetters
{
    class Movies
    {
        public string title;
        public string director;
        private string rating;

        public Movies(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //properties are special methods that allow us to define a fetter and setter
        public string Rating
        {
            get { return rating; } //get the rating attribute
            set {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            } //set the rating ie modify the rating
        }
    }
}
