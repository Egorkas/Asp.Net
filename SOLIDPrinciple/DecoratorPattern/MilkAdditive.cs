using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class MilkAdditive : TeaAdditiveDecorator
    {
        public MilkAdditive(Tea cupOfTea) : base(cupOfTea)
        {
            Price += 1;
            Name += " with milk";
        }
    }
}
