using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PDFDocumentBuilder : PresentationBuilder
    {
        private PDFDocument PDFDocument = new PDFDocument();

        public void AddSlide(Slide slide)
        {
            PDFDocument.AddText(slide.text);
        }

        public PDFDocument GetPDFDocument()
        {
            return PDFDocument;
        }
    }
}
