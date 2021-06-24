using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Customer customer = new Customer();

            List<Item> items = new List<Item>();

            items.Add(new Item("Juice", 2));
            items.Add(new Item("Book", 8));
            items.Add(new Item("Candy", 4));
            Console.WriteLine("Hello, are you here to buy or just look around?");
            while (input != "Exit")
            {
                input = Console.ReadLine();
                string[] command = input.Split(" ");

                int amount = 0;
                if (command.Length == 2)
                {
                    if (input.StartsWith("Buy"))
                    {
                        List<Item> newItem = items.Where(item => item.Name == command[1]).ToList();
                        Item listItem = newItem.First();
                        if (newItem.Count != 0)
                        {
                            customer.Buy(listItem);
                        }
                        else if (newItem.Count == 0)
                        {
                            Console.WriteLine("Sorry, we don't have this item! ");
                        }

                    }
                }
                if (command.Length == 3)
                {
                    if (input.StartsWith("Buy"))
                    {
                        amount = int.Parse(command[2]);
                        List<Item> newItem = items.Where(item => item.Name == command[1]).ToList();
                        Item listItem = newItem.First();
                        if (amount > 0 && newItem.Count != 0)
                        {
                            listItem.Quantity = amount;
                            customer.BuySpecificAmount(listItem);

                        }
                        else if (newItem.Count == 0)
                        {
                            Console.WriteLine("Sorry, we don't have this item! ");
                        }

                    }
                }
                if (input.StartsWith("TopUp"))
                {
                    Console.WriteLine("How much do you want to add?");
                    input = Console.ReadLine();
                    customer.TopUp(input);
                }

                if (input != null && input.StartsWith("MoneyLeft"))
                {
                    customer.AmountLeft(input);
                }
                Console.WriteLine("Choose what to do: Buy, TopUp, MoneyLeft");

            }
        }
    }
}
