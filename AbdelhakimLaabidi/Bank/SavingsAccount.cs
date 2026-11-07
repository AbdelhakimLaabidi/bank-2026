namespace BankApp
{
    public class SavingsAccount : Account
    {
        public DateTime DateLastWithdraw { get; private set; }

        public SavingsAccount(string number, Person owner)
            : base(number, owner)
        {
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Solde insuffisant : un carnet d'épargne ne peut pas être négatif.");
            }

            base.Withdraw(amount);
            DateLastWithdraw = DateTime.Now;
        }
    }
}