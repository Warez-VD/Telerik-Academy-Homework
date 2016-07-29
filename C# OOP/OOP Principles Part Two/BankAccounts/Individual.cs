namespace BankAccounts
{
    using System;

    public class Individual : Customer
    {
        private int age;

        public Individual(string firstName, string lastName, int age) 
            : base(firstName, lastName)
        {
            this.Age = age;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Customers must be 18 years old");
                }

                this.age = value;
            }
        }
    }
}
