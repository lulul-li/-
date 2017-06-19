using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            var shoppingCar = new List<Book>()
            {
                new Book {Series = 1, Count = 1}
            };
            var target = new DiscountCalcualtor();
            var expected = 100;

            var actual = target.CalculatePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_should_be_190()
        {
            var shoppingCar = new List<Book>()
            {
                new Book {Series = 1, Count = 1},
                new Book {Series = 2, Count = 1}
            };
            var target = new DiscountCalcualtor();
            var expected = 190;

            var actual = target.CalculatePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_series3_1_should_be_270()
        {
            var shoppingCar = new List<Book>()
            {
                new Book {Series = 1, Count = 1},
                new Book {Series = 2, Count = 1},
                new Book {Series = 3, Count = 1}
            };
            var target = new DiscountCalcualtor();
            var expected = 270;

            var actual = target.CalculatePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_series3_1_series4_1_should_be_320()
        {
            var shoppingCar = new List<Book>()
            {
                new Book {Series = 1, Count = 1},
                new Book {Series = 2, Count = 1},
                new Book {Series = 3, Count = 1},
                new Book {Series = 4, Count = 1}
            };
            var target = new DiscountCalcualtor();
            var expected = 320;

            var actual = target.CalculatePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_series1_1_series2_1_series3_1_series4_1_series5_1_should_be_375()
        {
            var shoppingCar = new List<Book>()
            {
                new Book {Series = 1, Count = 1},
                new Book {Series = 2, Count = 1},
                new Book {Series = 3, Count = 1},
                new Book {Series = 4, Count = 1},
                new Book {Series = 5, Count = 1}
            };
            var target = new DiscountCalcualtor();
            var expected = 375;

            var actual = target.CalculatePayoutMoney(shoppingCar);

            Assert.AreEqual(expected, actual);
        }
    }
}
