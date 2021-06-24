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

                if (input != null && input.StartsWith("Buy"))
                {

                    string[] command = input.Split(" ");
                    string commandSeperated = command[1];
                    int amount = 0;
                    if (command[2] !=null)
                    {
                        amount = int.Parse(command[2]);
                    }
                    List<Item> newItem = items.Where(item => item.Name == commandSeperated).ToList();
                    Item listItem = newItem.First();
                    if (amount == 0 && newItem.Count != 0)
                    {
                        listItem.Quantity = amount;
                        customer.Buy(listItem);
                    }
                    else if (amount > 0 && newItem.Count != 0)
                    {
                        listItem.Quantity = amount;
                        customer.BuySpecificAmount(listItem);

                    }
                    else if(newItem.Count == 0)
                    {
                        Console.WriteLine("Sorry, we don't have this item! ");
                    }

                }

                if (input != null && input.StartsWith("TopUp"))
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
