using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SugarAdditive : TeaAdditiveDecorator
    {
        public SugarAdditive(Tea cupOfTea) : base(cupOfTea)
        {
            Price += 1;
            Name += " with sugar";
        }
    }
}
