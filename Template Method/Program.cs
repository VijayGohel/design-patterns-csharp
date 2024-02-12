using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMiner task = new ExcelDataMiner();
            task.Execute();

            Console.ReadLine();
        }
    }
}
