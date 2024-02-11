using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;

            Context context = new Context();
            context.SetStrategy(new StrategyAdd());
            int res = context.ExecuteStategy(a, b);
            Console.WriteLine(res);

            context.SetStrategy(new StrategyMultiply());
            res = context.ExecuteStategy(a, b);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
