using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ant
{
    internal class AntWidgetFactory : WidgetFactory
    {
        public Button CreateButton()
        {
            return new AntButton();
        }

        public TextBox CreateTextBox()
        {
            return new AntTextBox();
        }
    }
}
