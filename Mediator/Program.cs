using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArticleDialogBox articleDialog = new();
            articleDialog.SimulateUserInteraction();
            Console.ReadLine();
        }
    }
}
