using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class State
    {
        protected Context _context;

        public abstract void Handle1();
        public abstract void Handle2();

        public void SetContext(Context context) 
        {
            this._context = context;
        }
    }
}
