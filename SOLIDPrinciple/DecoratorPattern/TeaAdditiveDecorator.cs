using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class TeaAdditiveDecorator : Tea
    {
        protected Tea CupOfTea { get; set; }

        public TeaAdditiveDecorator(Tea cupOfTea) : base(cupOfTea.Name)
        {
            CupOfTea = cupOfTea ?? throw new ArgumentNullException(nameof(cupOfTea));
            Price = cupOfTea.Price;
        }
    }
}
