using BankApp;

Bank bank = new Bank("Banque Laabidi");

Person abdel = new Person("Abdelhakim", "Laabidi", new DateTime(2000, 1, 15));
Person sarah = new Person("Sarah", "Dupont", new DateTime(1998, 6, 3));

CurrentAccount account1 = new CurrentAccount("BE01-0001", abdel, 500);
CurrentAccount account2 = new CurrentAccount("BE01-0002", abdel);
CurrentAccount account3 = new CurrentAccount("BE01-0003", sarah);

bank.AddAccount(account1);
bank.AddAccount(account2);
bank.AddAccount(account3);

account1.Deposit(1000);
account2.Deposit(250);
account3.Deposit(4000);

Console.WriteLine($"Solde BE01-0001 : {bank.GetBalance("BE01-0001")} €");
Console.WriteLine($"Total d'Abdelhakim : {bank.GetTotalBalance(abdel)} €");
Console.WriteLine($"Total de Sarah : {bank.GetTotalBalance(sarah)} €");