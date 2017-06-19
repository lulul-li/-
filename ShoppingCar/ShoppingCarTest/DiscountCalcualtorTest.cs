﻿using System;
using System.Collections.Generic;
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
            var shoppingCar = new[] { 1,0 };
            var target= new DiscountCalcualtor();
            var expected = 100;

            var actual = target.CalcualtePayoutMoney(shoppingCar);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_should_be_190()
        {
            var shoppingCar = new[] { 1, 1 };
            var target = new DiscountCalcualtor();
            var expected = 190;

            var actual = target.CalcualtePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_series3_1_should_be_270()
        {
            var shoppingCar = new[] {1, 1, 1};
            var target = new DiscountCalcualtor();
            var expected = 270;

            var actual = target.CalcualtePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }
    }
}
