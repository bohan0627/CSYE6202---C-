using System;
namespace Bo_Han_Assignment2
{
    public class Stock : AbstractStock
    {
        public int Id;
        public double Price;
        public string Symbol;
        public string Name;

        public Stock()
        {
        }

        public Stock(int Id, double Price, string Symbol, string Name) {
            this.Id = Id;
            this.Price = Price;
            this.Symbol = Symbol;
            this.Name = Name;
        }

        public override double Update(int percentChange)
        {
            this.Price = this.Price * (1 + percentChange / 100.00);
            //throw new NotImplementedException();
            return this.Price;
        }

        public override string ToString()
        {
            return $"#Id: {Id} Price: ${Price} Symbol:{Symbol} Name:{Name} ";
        }
    }
}
