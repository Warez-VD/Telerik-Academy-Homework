namespace MainProgram
{
    public class Battery
    {
        //instance field
        private BatteryType type;
        
        //Constructors
        public Battery()
            : this(null, null, null, BatteryType.LiIon)
        {

        }

        public Battery(string model)
            : this(model, null, null, BatteryType.LiIon)
        {

        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType typeOfBattery)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeOfBattery = typeOfBattery;
        }
        
        //Properties
        public string Model { get; set; }

        public int? HoursIdle { get; set; }

        public int? HoursTalk { get; set; }

        public BatteryType TypeOfBattery
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}
