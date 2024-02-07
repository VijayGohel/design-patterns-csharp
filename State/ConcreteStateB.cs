using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request...");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request...");
            Console.WriteLine("ConcreateStateA wants to change state");
            this._context.SetState(new ConcreteStateA());
        }
    }
}
