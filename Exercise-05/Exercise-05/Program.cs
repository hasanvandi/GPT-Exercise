using Exercise_05;

BankAccount bankAccount = new("0098732342354","MahdiHasanvandi",1000);
BankAccount bankAccount2 = new();

bankAccount.Deposit(55);
decimal myBalance = bankAccount.GetBalance();
Console.WriteLine("Your account balance is:" + myBalance);

bankAccount2.Deposit(100);
decimal myBalance2 = bankAccount2.GetBalance();
Console.WriteLine("Your account balance is:" + myBalance2);

bankAccount.Withdraw(20);
decimal myBalance1 = bankAccount.GetBalance();
Console.WriteLine($"Your account balance is:{myBalance1}");


bankAccount2.Withdraw(30);
decimal myBalance3 = bankAccount2.GetBalance();
Console.WriteLine("Your account balance is:" + myBalance3);

bankAccount.DisplayInfo();
bankAccount2.DisplayInfo();

Console.ReadLine();