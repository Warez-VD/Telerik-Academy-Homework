namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        protected Customer customer;
        private decimal balance;
        private decimal interestRate;
        private CurrencyType currency;

        public Account(Customer customer, decimal balance, decimal interestRate, CurrencyType currency)
        {
            this.customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Currency = currency;
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (interestRate < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative.");
                }

                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative.");
                }

                this.balance = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.customer.FullName;
            }
        }

        public CurrencyType Currency { get; private set; }

        public abstract decimal InterestAmountForPeriod(int months);

        //public abstract decimal WithDraw(decimal money);
    }
}
