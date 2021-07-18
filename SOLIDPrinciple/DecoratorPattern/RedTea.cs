using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class RedTea : Tea
    {
        public RedTea() : base("Red tea")
        {
            Price += 1;
        }
    }
}
