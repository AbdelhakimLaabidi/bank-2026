namespace BankApp
{
    public class CurrentAccount
    {
        public string Number { get; set; }
        public double Balance { get; private set; }
        public double CreditLine { get; set; }
        public Person Owner { get; set; }

        public CurrentAccount(string number, Person owner, double creditLine = 0)
        {
            Number = number;
            Owner = owner;
            CreditLine = creditLine;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Le montant doit être positif.");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Le montant doit être positif.");
            }

            if (Balance - amount < -CreditLine)
            {
                throw new InvalidOperationException("Solde insuffisant : ligne de crédit dépassée.");
            }

            Balance -= amount;
        }
    }
}

