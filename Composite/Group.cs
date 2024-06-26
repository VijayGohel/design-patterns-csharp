using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Group : Component
    {
        List<Component> components = new List<Component>();

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Render()
        {
            foreach (var component in components)
            {
                component.Render();
            }
        }
    }
}
