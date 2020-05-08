namespace Loaf
{
    public class Bread
    {
        private int _breadAmount;

        private int _breadPrice;
        public Bread(int breadAmount, int breadPrice)
        {
            _breadAmount = breadAmount;
            _breadPrice = breadPrice;
        }

        public int GetBreadPrice()
        {
            return _breadPrice;
        }

        public void SetBread(int loafAmount)
        {
            _breadAmount = loafAmount;
        }
    }
}