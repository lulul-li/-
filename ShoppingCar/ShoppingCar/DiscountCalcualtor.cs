using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCar
{
    public class DiscountCalcualtor
    {
        public decimal CalcualtePayoutMoney(int bookCount, int series2BookCount)
        {
            var price = 100;
            return bookCount * price;
        }
    }
}
