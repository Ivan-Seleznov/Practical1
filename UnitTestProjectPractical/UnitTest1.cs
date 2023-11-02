using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practical1;

namespace UnitTestProjectPractical
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountMultiplesOf27_ShouldReturnCorrectCount()
        {
            int num1 = 27;
            int num2 = 54;
            int num3 = 81;

            CountMultiples calculateABC = new CountMultiples(num1, num2, num3);
            int actualCount = calculateABC.CountMultiplesOf27();

            Assert.AreEqual(3, actualCount);
        }

        [TestMethod]
        public void CountMultiplesOf27_ShouldReturnZeroWhenNoMultiples()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            CountMultiples calculateABC = new CountMultiples(num1, num2, num3);
            int actualCount = calculateABC.CountMultiplesOf27();

            Assert.AreEqual(0, actualCount);
        }

        [TestMethod]
        public void CountMultiplesOf27_ShouldReturnOneWhenOneMultiple()
        {
            int num1 = 40;
            int num2 = 50;
            int num3 = 27;

            CountMultiples calculateABC = new CountMultiples(num1, num2, num3);
            int actualCount = calculateABC.CountMultiplesOf27();

            Assert.AreEqual(1, actualCount);
        }

        [TestMethod]
        public void СalculationAB_TestCountNumbers()
        {
            int a = 1;
            int b = 1000;
            int expectedResult = 4;

            CalculationAB calculationAB = new CalculationAB(a, b);
            int result = calculationAB.CountNumbers();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void СalculationAB_TestCountNumbersWithNegativeRange()
        {
            int a = -100;
            int b = 100;
            int expectedResult = 0;

            CalculationAB calculationAB = new CalculationAB(a, b);
            int result = calculationAB.CountNumbers();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void СalculationAB_TestCountNumbersWithSingleNumberRange()
        {
            int a = 17;
            int b = 17;
            int expectedResult = 0;

            CalculationAB calculationAB = new CalculationAB(a, b);
            int result = calculationAB.CountNumbers();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
