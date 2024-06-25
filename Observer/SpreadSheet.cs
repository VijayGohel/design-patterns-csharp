using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class SpreadSheet : Observer
    {
        DataSource _dataSource;
        public SpreadSheet(DataSource dataSource) 
        { 
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet got updated." + _dataSource.value);
        }
    }
}
