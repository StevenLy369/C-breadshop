namespace Poptarts
{
    public class Pastry
    {
        private int _pastryAmount;
    
        private int _price;

        private int _pastry;


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

        // public int GetPasteryPrice()
        // {
        //     return _pastery;
        // }

        public int SetPastryTotal(int pasteries)
        {
            if( _pastryAmount == 1)
            {
               return _price = 2;
            } else if (_pastryAmount == 3)
            {
               return _price = 5;
            }else{
                return (_price = _pastryAmount * 2);
            }
        }

    }
}