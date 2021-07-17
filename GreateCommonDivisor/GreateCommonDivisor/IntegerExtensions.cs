using System;
using System.Collections.Generic;
using System.Text;

namespace GreateCommonDivisor
{
    public static class IntegerExtensions
    {
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers can't be 0 at the same time.");
            }
            else if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number can't be {int.MinValue}.");
            }

            while (b != 0)
            {
                var temp = a % b;
                a = b;
                b = temp;
            }

            return Math.Abs(a);
        }
    }
}
