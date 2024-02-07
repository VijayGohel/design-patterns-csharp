using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string content;

        public string GetContent() 
        { 
            return content; 
        }

        public void SetContent(string content) 
        { 
            this.content = content; 
        }

        public Memento CreateState() 
        {
            return new Memento(content);
        }

        public void Restore(Memento memento)
        {
            content = memento.GetContent();
        }
    }
}
