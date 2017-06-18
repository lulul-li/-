using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCar
{
    public class DiscountCalcualtor
    {
        public decimal CalcualtePayoutMoney(int series1BookCount, int series2BookCount)
        {
            var price = 100;
            var discount = 0.95m;
            if (series1BookCount == 0 || series2BookCount == 0)
            {
                return (series1BookCount + series2BookCount) * price;
            }

            var setCount = series1BookCount - series2BookCount;
            var payoutMoney = (series1BookCount - setCount + series2BookCount) * price * discount;
            payoutMoney += setCount*price;

            return payoutMoney;
        }
    }
}
