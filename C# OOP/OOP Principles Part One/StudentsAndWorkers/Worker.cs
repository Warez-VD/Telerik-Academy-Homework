namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }
        
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (WeekSalary / 5) / WorkHoursPerDay;

            return moneyPerHour;
        }
    }
}
