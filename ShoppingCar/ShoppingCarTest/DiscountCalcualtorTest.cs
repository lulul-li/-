using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCar;

namespace ShoppingCarTest
{
    [TestClass]
    public class DiscountCalcualtorTest
    {
        [TestMethod]
        public void Buy_series1_1_should_be_100()
        {
            var bookCount = 1;
            var target= new DiscountCalcualtor();
            var expected = 100;

            var actual = target.CalcualtePayoutMoney(bookCount,0);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_should_be_190()
        {
            var series1bookCount = 1;
            var series2bookCount = 1;
            var target = new DiscountCalcualtor();
            var expected = 190;

            var actual = target.CalcualtePayoutMoney(series1bookCount, series2bookCount);

            Assert.AreEqual(expected, actual);
        }
    }
}
