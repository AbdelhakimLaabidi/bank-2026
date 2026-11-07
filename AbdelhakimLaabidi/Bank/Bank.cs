namespace BankApp
{
    public class Bank
    {
        public string Name { get; set; }
        public Dictionary<string, Account> Accounts { get; }

        public Bank(string name)
        {
            Name = name;
            Accounts = new Dictionary<string, Account>();
        }

        public void AddAccount(Account account)
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

        public double GetBalance(string number)
        {
            if (!Accounts.ContainsKey(number))
            {
                throw new KeyNotFoundException($"Le compte {number} n'existe pas.");
            }

            return Accounts[number].Balance;
        }

        public double GetTotalBalance(Person owner)
        {
            double total = 0;

            foreach (Account account in Accounts.Values)
            {
                if (account.Owner == owner)
                {
                    total += account.Balance;
                }
            }

            return total;
        }
    }
}