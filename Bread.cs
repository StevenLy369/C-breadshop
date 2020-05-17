namespace Loaf
{
    public class Bread
    {
        private int _breadAmount {get;set;}

        private int _breadPrice{get;set;}
        public Bread(int breadPrice, int breadAmount) 
        {
            
            
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
            return _breadPrice = ((_breadAmount * 5) - (_breadAmount / 2 * 5 ));

          
        }
    }
}