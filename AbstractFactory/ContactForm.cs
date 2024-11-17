using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ContactForm
    {
        public void Render(WidgetFactory widgetFactory)
        {
            widgetFactory.CreateTextBox().Render();
            widgetFactory.CreateButton().Render();
        }
    }
}
