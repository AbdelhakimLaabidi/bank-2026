namespace BankApp
{
    public abstract class Account
    {
        public string Number { get; set; }
        public double Balance { get; private set; }
        public Person Owner { get; set; }

        public Account(string number, Person owner)
        {
            Number = number;
            Owner = owner;
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
        
        public virtual void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Le montant doit être positif.");
            }

            Balance -= amount;
        }

        protected abstract double CalculInterets();
        
    }
}