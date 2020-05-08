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
            
            Console.WriteLine(@"                                                                 _______                       __       
/       \                                     /  | /      \ /  |                                /       \                     /  |      
$$$$$$$  |  ______    ______    ______    ____$$ |/$$$$$$  |$$ |____    ______    ______        $$$$$$$  |  ______   __    __ $$ |____  
$$ |__$$ | /      \  /      \  /      \  /    $$ |$$ \__$$/ $$      \  /      \  /      \       $$ |__$$ | /      \ /  |  /  |$$      \ 
$$    $$< /$$$$$$  |/$$$$$$  | $$$$$$  |/$$$$$$$ |$$      \ $$$$$$$  |/$$$$$$  |/$$$$$$  |      $$    $$< /$$$$$$  |$$ |  $$ |$$$$$$$  |
$$$$$$$  |$$ |  $$/ $$    $$ | /    $$ |$$ |  $$ | $$$$$$  |$$ |  $$ |$$ |  $$ |$$ |  $$ |      $$$$$$$  |$$ |  $$/ $$ |  $$ |$$ |  $$ |
$$ |__$$ |$$ |      $$$$$$$$/ /$$$$$$$ |$$ \__$$ |/  \__$$ |$$ |  $$ |$$ \__$$ |$$ |__$$ |      $$ |__$$ |$$ |      $$ \__$$ |$$ |  $$ |
$$    $$/ $$ |      $$       |$$    $$ |$$    $$ |$$    $$/ $$ |  $$ |$$    $$/ $$    $$/       $$    $$/ $$ |      $$    $$/ $$ |  $$ |
$$$$$$$/  $$/        $$$$$$$/  $$$$$$$/  $$$$$$$/  $$$$$$/  $$/   $$/  $$$$$$/  $$$$$$$/        $$$$$$$/  $$/        $$$$$$/  $$/   $$/ 
                                                                                $$ |                                                    
                                                                                $$ |                                                    
                                                                                $$/        
   ");
            Pastry pastryOrder  = new Pastry(2,0);
            Bread breadOrder = new Bread(5,0);
            List<Bread> Bread = new List<Bread>(){};
            List<Pastry> Pastry = new List<Pastry>(){};
            
    
            Console.WriteLine("How many Pasteries");
            string amount = Console.ReadLine();
            int pasteries = int.Parse(amount);
            pastryOrder.SetPastry(pasteries);
            pastryOrder.SetPastryTotal(pasteries);
            



           Console.WriteLine("How many loafs of bread");
           string breadAmount = Console.ReadLine();
           int loafs = int.Parse(breadAmount);
           breadOrder.SetBread(loafs);
           breadOrder.SetBreadTotal(loafs);
           Console.WriteLine(@"
 ________  __                            __                                                  _______                       __       
/        |/  |                          /  |                                                /       \                     /  |      
$$$$$$$$/ $$ |____    ______   _______  $$ |   __        __    __   ______   __    __       $$$$$$$  |  ______   __    __ $$ |____  
   $$ |   $$      \  /      \ /       \ $$ |  /  |      /  |  /  | /      \ /  |  /  |      $$ |__$$ | /      \ /  |  /  |$$      \ 
   $$ |   $$$$$$$  | $$$$$$  |$$$$$$$  |$$ |_/$$/       $$ |  $$ |/$$$$$$  |$$ |  $$ |      $$    $$< /$$$$$$  |$$ |  $$ |$$$$$$$  |
   $$ |   $$ |  $$ | /    $$ |$$ |  $$ |$$   $$<        $$ |  $$ |$$ |  $$ |$$ |  $$ |      $$$$$$$  |$$ |  $$/ $$ |  $$ |$$ |  $$ |
   $$ |   $$ |  $$ |/$$$$$$$ |$$ |  $$ |$$$$$$  \       $$ \__$$ |$$ \__$$ |$$ \__$$ |      $$ |__$$ |$$ |      $$ \__$$ |$$ |  $$ |
   $$ |   $$ |  $$ |$$    $$ |$$ |  $$ |$$ | $$  |      $$    $$ |$$    $$/ $$    $$/       $$    $$/ $$ |      $$    $$/ $$ |  $$ |
   $$/    $$/   $$/  $$$$$$$/ $$/   $$/ $$/   $$/        $$$$$$$ | $$$$$$/   $$$$$$/        $$$$$$$/  $$/        $$$$$$/  $$/   $$/ 
                                                        /  \__$$ |                                                                  
                                                        $$    $$/                                                                   
                                                         $$$$$$/                                                                    
           ");
           Console.WriteLine("Your Total for bread is : $ " + breadOrder.GetBreadPrice() +" And your total for pasteries is: $ " + pastryOrder.GetPrice() );
        }
    }
}