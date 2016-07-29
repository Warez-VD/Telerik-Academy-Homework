namespace BankAccounts
{
    using System;

    public class Deposit : Account, IWithDrawable, IDepositable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate, CurrencyType currency)
            : base(customer, balance, interestRate, currency)
        {
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public override decimal InterestAmountForPeriod(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }

            return months * this.InterestRate;
        }
        
        public decimal WithDraw(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Cannot withdraw negative money");
            }
            else if (money > this.Balance)
            {
                throw new ArgumentException("Cannot withdraw more than the money you already have");
            }
            else
            {
                this.Balance -= money;
                return money;
            }
        }
    }
}
