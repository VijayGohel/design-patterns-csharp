using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class ExcelDataMiner : DataMiner
    {
        protected override void CloseFile(string file)
        {
            Console.WriteLine($"Closing file {file} in ExcelDataMiner");
        }

        protected override void ExtractData(string file)
        {
            Console.WriteLine($"Extracting data from file {file} in ExcelDataMiner");
        }

        protected override void OpenFile(string path)
        {
            Console.WriteLine($"Opening file from {path} in ExcelDataMiner");
        }

        protected override void ParseData(string rawData)
        {
            Console.WriteLine($"Parsing data in ExcelDataMiner");
        }
    }
}
