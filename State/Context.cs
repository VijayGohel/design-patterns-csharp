using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        private State _state;
        public Context(State state) 
        {
            this.SetState(state);
        }

        public void Request1()
        {
            this._state.Handle1();
        }
        public void Request2()
        {
            this._state.Handle2();
        }
        public void SetState(State state)
        {
            Console.WriteLine("Changing state");
            this._state = state;
            this._state.SetContext(this);
        }
    }
}
