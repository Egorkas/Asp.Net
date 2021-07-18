using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Tea
    {
        public string Name { get; protected set; }

        public int Price { get; protected set; }

        public Tea(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Price = 3;
        }
    }
}
