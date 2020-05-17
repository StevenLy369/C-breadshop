namespace Poptarts
{
    public class Pastry
    {
        private int _pastryAmount{get;set;}
    
        private int _price{get;set;}

        public Pastry(int price, int pastryAmount)
        {

        }

        public int GetPrice()
        {
            return _price;
        }

        public void SetPastry(int amount)
        {
            _pastryAmount = amount;
        }

        public int GetpastryAmount()
        {
            return _pastryAmount;
        }

        public int SetPastryTotal(int pasteries)
        {

            return _price = ((_pastryAmount * 2) - (_pastryAmount / 3 ));
     
         }

    }
}