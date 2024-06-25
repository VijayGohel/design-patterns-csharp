using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSource dataSource = new DataSource();
            //pull style communcation - coupling between observer and observable to get values, push style - get values from observable through update method
            dataSource.AddObserver(new Chart(dataSource));
            dataSource.AddObserver(new SpreadSheet(dataSource));

            dataSource.value = 5;
            Console.ReadLine();
        }
    }
}
