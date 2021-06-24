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

            List<Item> Items = new List<Item>();

            Items.Add(new Item("Juice", 2));
            Items.Add(new Item("Book", 8));
            Items.Add(new Item("Candy", 4));
            Console.WriteLine("Hello, are you here to buy or just look around?");
            while (input != "Exit")
            {
                input = Console.ReadLine();

                if (input.StartsWith("Buy"))
                {
                    string[] command = input.Split(" ");
                    string commandSeperated = command[1];
                    List<Item> newItem = Items.Where(item => item.Name == commandSeperated).ToList();
                    if (newItem.Count != 0)
                    {
                        Item listItem = newItem.First();
                        customer.Buy(listItem);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we dont have this item! ");
                    }

                }

                if (input.StartsWith("TopUp"))
                {
                    Console.WriteLine("How much do you want to add?");
                    input = Console.ReadLine();
                    customer.TopUp(input);
                }

                if (input.StartsWith("MoneyLeft"))
                {
                    customer.AmountLeft(input);
                }

                Console.WriteLine("Choose what to do: Buy, TopUp, MoneyLeft");
            }
        } 
    }
}
