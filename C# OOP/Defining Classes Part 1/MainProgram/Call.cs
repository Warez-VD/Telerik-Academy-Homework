namespace MainProgram
{
    using System;
    using System.Text;

    public class Call
    {
        //Constructor
        public Call(DateTime dateAndTime, string phoneNumber, int duration)
        {
            this.Date = dateAndTime.ToLongDateString();
            this.Time = dateAndTime.ToShortTimeString();
            this.DialledPhone = phoneNumber;
            this.Duration = duration;
        }

        //Properties
        public string Date { get; private set; }

        public string Time { get; private set; }

        public string DialledPhone { get; private set; }

        public int Duration { get; private set; }

        //Method
        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(string.Format("Call made on: {0} {1}\nDialled number: {2}\nDuration of call: {3} sec.\n", this.Date, this.Time, this.DialledPhone, this.Duration));

            return result.ToString(); 
        }
    }
}
