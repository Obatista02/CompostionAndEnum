using Course.entities;
using Course.entities.Exception;

try { 
Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial Balance: ");
double balance = double.Parse(Console.ReadLine());
Console.Write("Withdraw Limit: ");
double limit = double.Parse(Console.ReadLine());    

Account account = new Account(number,holder,balance,limit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine());
account.Withdraw(amount);
Console.WriteLine("Nem balance: "+ account.Balance);
}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (AccountException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}