using System;
using System.Collections.Generic;
using Bakery;

namespace BakeryShop
{
    public class Program
    {
        public static void Main()
        {
            

            List<Pastry> newPastery = new List<Pastry>(){};
            Console.WriteLine("Hello, Please press 1 for Bread and 2 for Pasteries. Please note there is a special. Bread: buy 2 get one free($5/per) or Pastery: 1 for $2 or 3 for $5");
            newPastery.pastryAmount = Console.ReadLine();



            Pastry newPastery = new Pastry(pastryAmount);
        }



    }
}