using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class MovieBuilder : PresentationBuilder
    {
        private Movie movie = new Movie();
        
        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.text, 3);
        }

        public Movie GetMovie()
        {
            return movie;
        }
    }
}
