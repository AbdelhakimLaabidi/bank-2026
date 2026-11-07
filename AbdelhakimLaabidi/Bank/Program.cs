using BankApp;

Bank bank = new Bank("Banque Laabidi");

Person owner = new Person("Abdelhakim", "Laabidi", new DateTime(2000, 1, 15));

CurrentAccount account1 = new CurrentAccount("BE01-0001", owner, 500);
CurrentAccount account2 = new CurrentAccount("BE01-0002", owner);

bank.AddAccount(account1);
bank.AddAccount(account2);
Console.WriteLine($"{bank.Name} : {bank.Accounts.Count} comptes");

bank.DeleteAccount("BE01-0002");
Console.WriteLine($"Après suppression : {bank.Accounts.Count} compte");

try
{
    bank.AddAccount(account1);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}

