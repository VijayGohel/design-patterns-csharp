using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Chart : Observer
    {
        DataSource _dataSource;
        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got updated." + _dataSource.value);
        }
    }
}
