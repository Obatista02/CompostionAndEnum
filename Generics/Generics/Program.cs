using Generics;

PrintService<string> printService = new PrintService<string>();

Console.Write("how many values? ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string x = Console.ReadLine();

    printService.AddValue(x);

}
printService.Print();
Console.WriteLine("First: "+ printService.First());