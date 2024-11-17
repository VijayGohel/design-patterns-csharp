using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Presentation
    {
        List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        { slides.Add(slide); }

        public void Export(PresentationBuilder presentationBuilder)
        {
            presentationBuilder.AddSlide(new Slide("Copyright"));
            foreach (Slide slide in slides) 
            {
                presentationBuilder.AddSlide(slide);
            }
        }
    }
}
