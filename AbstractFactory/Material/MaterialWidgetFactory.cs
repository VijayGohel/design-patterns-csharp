using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Material
{
    internal class MaterialWidgetFactory : WidgetFactory
    {
        public Button CreateButton()
        {
            return new MaterialButton();
        }

        public TextBox CreateTextBox()
        {
            return new MaterialTextBox();
        }
    }
}
