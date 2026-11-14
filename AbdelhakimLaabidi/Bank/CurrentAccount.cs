namespace BankApp
{
    public class CurrentAccount : Account
    {
        public double CreditLine { get; set; }

        public CurrentAccount(string number, Person owner)
            : base(number, owner)
        {
            CreditLine = 0;
        }

        public CurrentAccount(string number, Person owner, double creditLine)
            : this(number, owner)
        {
            CreditLine = creditLine;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount < -CreditLine)
            {
                throw new InvalidOperationException("Solde insuffisant : ligne de crédit dépassée.");
            }

            base.Withdraw(amount);
        }

        protected override double CalculInterets()
        {
            if (Balance > 0)
            {
                return Balance * 0.03;
            }

            return Balance * 0.0975;
        }
    }
}