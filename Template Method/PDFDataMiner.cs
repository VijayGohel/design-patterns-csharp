using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class PDFDataMiner : DataMiner
    {
        protected override void CloseFile(string file)
        {
            Console.WriteLine($"Closing file {file} in PDFDataMiner");
        }

        protected override void ExtractData(string file)
        {
            Console.WriteLine($"Extracting data from file {file} in PDFDataMiner");
        }

        protected override void OpenFile(string path)
        {
            Console.WriteLine($"Opening file from {path} in PDFDataMiner");
        }

        protected override void ParseData(string rawData)
        {
            Console.WriteLine($"Parsing data in PDFDataMiner");
        }
    }
}
