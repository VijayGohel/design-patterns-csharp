using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        private Handler next;
        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (next != null)
            {
                next.Handle(request);
            }
        }

        protected abstract Boolean DoHandle(HttpRequest request);
    }
}
