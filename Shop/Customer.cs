using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Customer
    {
        int wallet = 10;

        public void Buy(Item item)
        {
            if (wallet >= item.Value)
            {
                wallet = wallet - item.Value;
                Console.WriteLine("You have bought - " + item.Name);
            }
            else if (wallet < item.Value)
            {
                Console.WriteLine("You don't have enough money, get out of my shop!");
            }
        }

        public void TopUp(string text)
        {
            int amount = int.Parse(text);
            wallet = amount + wallet;
            Console.WriteLine($"New customer balance is {wallet}");
        }

        public void AmountLeft(string amount)
        {
            Console.WriteLine(wallet);
        }

        public void BuySpecificAmount(Item item)
        {
            int totalPrice = item.Value * item.Quantity;
            if (wallet >= totalPrice)
            {
                wallet = wallet - item.Value * item.Quantity;
                Console.WriteLine("You have bought - " + item.Name);
            }
            else if (wallet <= item.Value * item.Quantity)
            {
                Console.WriteLine("You don't have enough money, get out of my shop!");
            }
        }
    }
    }
