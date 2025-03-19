namespace Delegates.Func.Entities
{
    class ProductFunc
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductFunc(string name, double price)
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
