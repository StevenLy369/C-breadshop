using System;
using System.Collections.Generic;
using Poptarts;
using Loaf;




namespace BakeryShop
{
    public class Program
    {
        public static void Main()
        {

            Pastry pastryOrder = new Pastry(0, 2);
            Bread breadOrder = new Bread(0, 5);
            List<Bread> Bread = new List<Bread>() { };
            List<Pastry> Pastry = new List<Pastry>() { };


            Console.WriteLine("How many Pasteries");
            string amount = Console.ReadLine();
            int pastryAmount = int.Parse(amount);



            Console.WriteLine("How many loafs of bread");
            string bread = Console.ReadLine();
            int breadAmount = int.Parse(bread);



            Console.WriteLine("Your Total for bread is : $ " + breadOrder.BreadTotal(breadAmount) + " And your total for pasteries is: $ " + pastryOrder.PastryTotal(pastryAmount));
        }
    }
}