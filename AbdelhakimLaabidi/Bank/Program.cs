using BankApp;

Bank bank = new Bank("Banque Laabidi");

Person abdel = new Person("Abdelhakim", "Laabidi", new DateTime(2000, 1, 15));

CurrentAccount current = new CurrentAccount("BE01-0001", abdel, 500);
SavingsAccount savings = new SavingsAccount("BE02-0001", abdel);

bank.AddAccount(current);
bank.AddAccount(savings);

current.Deposit(1000);
savings.Deposit(2000);

current.Withdraw(1200);
savings.Withdraw(300);

Console.WriteLine($"Compte courant : {current.Balance} €");
Console.WriteLine($"Épargne : {savings.Balance} € (dernier retrait le {savings.DateLastWithdraw:dd/MM/yyyy})");
Console.WriteLine($"Total d'Abdelhakim : {bank.GetTotalBalance(abdel)} €");

try
{
    savings.Withdraw(5000);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}