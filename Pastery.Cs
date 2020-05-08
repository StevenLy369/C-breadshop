namespace Poptarts
{
    public class Pastery
    {
        private int _pasteryAmount;
        private int _bread;
        private int _Price;


        public Pastery(int price, int pastery)
        {
            _Price = price;
            _pastery = 0;

        }

        public int GetPrice()
        {
            return _Price;
        }

        // public int GetPasteryPrice()
        // {
        //     return _pastery;
        // }

        public int SetPasteryPrice()
        {
            if( _pasteryAmount == 1)
            {
               return _Price = 2;
            } else if (_pasteryAmount == 3)
            {
               return _Price = 5;
            }else{
                return _pasteryAmount * 2;
            }
        }

    }
}