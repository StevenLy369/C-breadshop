namespace Poptarts
{
    public class Pastry
    {
        public int PastryAmount{get;set;}
    
        public int Price{get;set;}

        public Pastry(int price, int pastryamount)
        {
            PastryAmount = pastryamount;
            Price = price;
        }

        public int PastryTotal(int pastryAmount)
        {

            return Price = ((pastryAmount* 2) - (pastryAmount / 3 ));
     
         }

    }
}