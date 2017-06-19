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

        public decimal CalculatePayoutMoney(List<Book> shoppingCar)
        {
            var price = 100;
            var payoutMoney = 0m;

            while (true)
            {
                var bookSet = shoppingCar.Count(x => x.Count > 0);
                if (bookSet == 0)
                {
                    break;
                }

                payoutMoney += bookSet * price * _discountMapping[bookSet];
                foreach (var book in shoppingCar)
                {
                    book.Count -= 1;
                }
            }
            return payoutMoney;
        }
    }
}
