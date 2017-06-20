using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCar
{
    public class DiscountCalcualtor
    {
        private readonly Dictionary<int, decimal> _discountMapping = new Dictionary<int, decimal>()
            {
                {1,1},
                {2,0.95m},
                {3,0.9m},
                {4,0.8m},
                {5,0.75m},
            };

        private readonly int _price = 100;

        public decimal CalculatePayoutMoney(List<Book> shoppingCar)
        {
            var payoutMoney = 0m;
            while (shoppingCar.Count(x => x.Count > 0) > 0)
            {
                var bookSet = shoppingCar.Count(x => x.Count > 0);
                payoutMoney += bookSet * _price * _discountMapping[bookSet];
                shoppingCar.ForEach(x => { x.Count -= 1; });
            }
            return payoutMoney;
        }
    }
}
