using PoliHera.entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product {i} data: ");
    Console.Write("Common, used or imported (c/u/i)?  ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price ");
    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

    if (resp == 'i')
    {
        Console.Write("Customs fee: ");
        double customesFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Product imported = new ImportedProduct(name, price, customesFee);
        list.Add(new ImportedProduct(name, price, customesFee));
    }if(resp == 'u')
    {
        Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
        DateTime dateTime = DateTime.Parse(Console.ReadLine());

        list.Add(new UsedProduct(name, price, dateTime));
    }
    else
    {
        list.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("Price Tag:");
foreach(Product emp in list)
{
    Console.WriteLine(emp.PriceTag());
}