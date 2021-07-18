using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class GreenTea : Tea
    {
        public GreenTea() : base("Green tea")
        {
            Price += 2;
        }
    }
}
