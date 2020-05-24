namespace Loaf
{
    public class Bread
    {
        public int BreadAmount {get;set;}

        public int BreadPrice{get;set;}
        public Bread(int breadPrice, int breadAmount) 
        {
            BreadPrice = breadPrice;
            BreadAmount = breadAmount;
            
        }
        public int BreadTotal(int breadAmount)
        {
            if (BreadAmount <= 2)
            {
                return BreadPrice = breadAmount * 5;
            }
            else
            {
                return BreadPrice = ((breadAmount * 5) - (breadAmount / 2 * 5 ));
            }
          
        }
    }
}


