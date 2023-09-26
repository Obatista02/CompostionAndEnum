
using Herança.entities;

Account aac1 = new Account(1001,"Alex", 500);
Account aac2 = new SavingAccount(1002, "Anna", 500,0.01);


aac1.WithDraw(10);
aac2.WithDraw(10);

Console.WriteLine(aac1.Balance);Console.WriteLine(aac2.Balance);