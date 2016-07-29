namespace BankAccounts
{
    public abstract class Customer : ICustomer
    {
        private string firstName;
        private string lastName;

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }
    }
}
