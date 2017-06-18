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

            var actual = target.CalcualtePayoutMoney(bookCount);

            Assert.AreEqual(expected,actual);
        }
    }
}
