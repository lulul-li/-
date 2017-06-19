using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCar
{
    public class DiscountCalcualtor
    {
        public decimal CalcualtePayoutMoney(int [] shoppingCar)
        {
            var price = 100;
            var discount = 0.95m;
            if (shoppingCar[0] == 0 || shoppingCar[1] == 0)
            {
                return (shoppingCar[0]+ shoppingCar[1]) * price;
            }

            var setCount = shoppingCar[0] - shoppingCar[1];
            var payoutMoney = (shoppingCar[0] - setCount + shoppingCar[1]) * price * discount;
            payoutMoney += setCount*price;

            return payoutMoney;
        }
    }
}
