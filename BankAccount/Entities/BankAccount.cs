namespace ExerciseBankAccount
{
    public class BankAccount
    {
        private readonly int _accountNumber;
        public string OwnerName { get; private set; }
        public double Amount { get; private set; }

        public BankAccount(int accountNumber, string ownerName)
        {
            this._accountNumber = accountNumber;
            this.OwnerName = ownerName;
        }

        public BankAccount(int accountNumber, string ownerName, double amount): this (accountNumber,ownerName)
        {
            Deposit(amount); //using Method
        }

        public void Deposit(double amount)
        {
            this.Amount += amount;
        }

        public void Draw(double amount)
        {
            this.Amount -= amount + 5;
        }

        public override string ToString()
        {
            return $"Account Number: {_accountNumber}, Owner: {OwnerName}, Amount $ {(Amount):f2}";
        }
    }
}
