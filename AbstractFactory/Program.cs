using AbstractFactory.Ant;
using AbstractFactory.Material;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactForm form = new ContactForm();
            form.Render(new AntWidgetFactory());
        }
    }
}
