using System.Globalization;

namespace PoliHera.entities
{
    class UsedProduct : Product
    {
        public DateTime Manufacturedate { get; set; }

        public UsedProduct() { }

        public UsedProduct(String name, double price,DateTime manufacturedate)
            :base(name, price)
        {
            Manufacturedate = manufacturedate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + Manufacturedate.ToString("DD/MM/YYYY")
                + ")";
        }
    }
}
