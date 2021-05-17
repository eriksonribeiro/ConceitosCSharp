namespace InheritanceAccountExample.Entities
{
    sealed class SavingAccount : Account //Sealed prohibit enharitence
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate)
    : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance(double amount)
        {
             this.Balance += this.Balance * amount;
        }

        public override void Withdaw(double amount)
        {
            base.Withdaw(amount);
            this.Balance -= 2.00;
        }
    }
}
