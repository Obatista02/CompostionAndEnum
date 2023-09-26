using System.Globalization;
namespace PoliHera.entities
{
     class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(String name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag()
        {
            return Name +" $ "+ Price.ToString("F1", CultureInfo.InvariantCulture);
        }
        
    }
}
