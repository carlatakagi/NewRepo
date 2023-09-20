using System.Globalization;

namespace Course
{
    class BankAccount
    {

        public int Number { get; private set; }
        public string Owner { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public BankAccount(int number, string owner, double balance) : this(number, owner)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Number
                + ", Owner: "
                + Owner
                + ", Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}