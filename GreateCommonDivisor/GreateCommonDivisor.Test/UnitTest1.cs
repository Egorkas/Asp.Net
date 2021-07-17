using System;
using NUnit.Framework;

namespace GreateCommonDivisor.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4,4,ExpectedResult = 4)]
        [TestCase(50,250,ExpectedResult = 50)]
        [TestCase(2672,5678,ExpectedResult = 334)]
        [TestCase(-12,30,ExpectedResult = 6)]
        [TestCase(int.MaxValue,int.MaxValue,ExpectedResult = int.MaxValue)]
        [TestCase(1071,0,ExpectedResult = 1071)]
        public int FindGcd_ForRightNumber(int a, int b) => IntegerExtensions.FindGcd(a, b);

        [Test]
        public void FindGcd_ForZeroNumbers() =>
            Assert.Throws<ArgumentException>(() => IntegerExtensions.FindGcd(0, 0),
                "Two numbers can't be 0 at the same time.");

        [TestCase(int.MinValue, 0)]
        [TestCase(0, int.MinValue)]
        [TestCase(-9, int.MinValue)]
        [TestCase(int.MinValue, 13)]
        [TestCase(int.MinValue, int.MinValue)]
        public void FindGcd_WithIntMin(int a, int b) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => IntegerExtensions.FindGcd(a, b),
                $"Number can't be {int.MinValue}.");
    }
}