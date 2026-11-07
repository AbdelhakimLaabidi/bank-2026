namespace BankApp
{
    public class Bank
    {
        public string Name { get; set; }
        public Dictionary<string, CurrentAccount> Accounts { get; }

        public Bank(string name)
        {
            Name = name;
            Accounts = new Dictionary<string, CurrentAccount>();
        }

        public void AddAccount(CurrentAccount account)
        {
            if (Accounts.ContainsKey(account.Number))
            {
                throw new InvalidOperationException($"Le compte {account.Number} existe déjà.");
            }

            Accounts.Add(account.Number, account);
        }

        public void DeleteAccount(string number)
        {
            if (!Accounts.Remove(number))
            {
                throw new KeyNotFoundException($"Le compte {number} n'existe pas.");
            }
        }
    }
}
