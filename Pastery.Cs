namespace Poptarts
{
    public class Pastry
    {
        private int _pastryAmount;
    
        private int _price;

        // private int _pastry;


        public Pastry(int price, int pastryAmount)
        {
            _price = price;
            _pastryAmount = pastryAmount;


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

            return _price = ((_pastryAmount * 2) - (_pastryAmount / 3   ));
     
         }

    }
}