using System;
using System.Collections.Generic;
using Poptarts;

namespace BakeryShop
{
    public class Program
    {
        public static void Main()
        {
            Pastry pastryOrder  = new Pastry(2,0);

            List<Pastry> Pastry = new List<Pastry>(){};
            
            //Console.WriteLine("Hello, Please press 1 for Bread and 2 for Pasteries. Please note there is a special. Bread: buy 2 get one free($5/per) or Pastery: 1 for $2 or 3 for $5");
            Console.WriteLine("How many Pasteries");
           string amount = Console.ReadLine();

           int pasteries = int.Parse(amount);
            pastryOrder.SetPastry(pasteries);
            pastryOrder.SetPastryPrice(pasteries);
            Console.WriteLine("Your Total is " + pastryOrder.GetPrice());


            

            
        }



    }
}