namespace Loaf
{
    public class Bread
    {
        private int _breadAmount;

        private int _breadPrice;
        public Bread(int breadPrice, int breadAmount) 
        {
            
            _breadPrice = breadPrice;
            _breadAmount = breadAmount;
        }

        public int GetBreadPrice()
        {
            return _breadPrice;
        }

        public void SetBread(int loafAmount)
        {
            _breadAmount = loafAmount;
        }

        public int SetBreadTotal(int breads)
        {
            if(_breadAmount == 2)
            {
                return _breadPrice = 5;
            }else if (_breadAmount == 1)
            {
                return _breadPrice = 5;
            }else
            {
                return _breadPrice = ( (_breadAmount * 5) - 5 );
            }
        }
    }
}