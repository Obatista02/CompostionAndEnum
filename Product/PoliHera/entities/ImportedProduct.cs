using System.Globalization;

namespace PoliHera.entities
{
   class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(String name, double price, double customsFee)
            :base(name,price)
        { 
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name +" $ "+ TotalPrice().ToString("F1", CultureInfo.InvariantCulture) + "(Customs fee: $ "
                +CustomsFee.ToString("F1", CultureInfo.InvariantCulture) + ")";
        }
    }   
}
