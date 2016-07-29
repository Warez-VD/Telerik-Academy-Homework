namespace MainProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        //static field
        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple");

        //instance fields
        private string model;
        private string manifacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        //Constructors
        public GSM(string model, string manifacturer)
            : this(model, manifacturer, null, null, new Battery(), new Display())
        {
        }

        public GSM(string model, string manifacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();
        }

        //Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            private set
            {
                this.manifacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be less than zero");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        //Methods
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("Model: " + this.Model);
            result.AppendLine("Manifacturer: " + this.Manifacturer);
            result.AppendLine(string.Format("Price: {0:C}", this.Price));
            result.AppendLine("Owner: " + this.Owner);
            result.AppendLine("Battery model: " + this.battery.Model);
            result.AppendLine("Battery hours idle" + this.battery.HoursIdle);
            result.AppendLine("Battery hours talk" + this.battery.HoursTalk);
            result.AppendLine("Battery type" + this.battery.TypeOfBattery);
            result.AppendLine("Screen size: " + this.display.Size);
            result.AppendLine("Number of colors: " + this.display.NumberOfColors);

            return result.ToString(); 
        }

        public string CallHistoryInformation()
        {
            var result = new StringBuilder();

            foreach (var call in callHistory)
            {
                result.Append(call);
            }

            return result.ToString();
        }

        public void AddCall(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCalls()
        {
            this.callHistory.Clear();
        }

        public void RemoveLongestCall()
        {
            int longestDuration = int.MinValue;

            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration > longestDuration)
                {
                    longestDuration = i;
                }
            }

            callHistory.Remove(callHistory[longestDuration]);
        }

        public decimal TotalPrice(decimal price)
        {
            decimal totalTime = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                totalTime += callHistory[i].Duration;
            }

            decimal totalPrice = totalTime * (price / 60);
            return totalPrice;
        }
    }
}
