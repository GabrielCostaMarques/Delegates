namespace Delegates.Predicate.Entities
{
    class ProductAction
    {
        public ProductAction()
        {
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public ProductAction(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " " + Price.ToString("F2");
        }

    }
}
