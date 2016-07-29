namespace MainProgram
{
    public class Display
    {
        //Constructors
        public Display()
            : this(null, null)
        {

        }

        public Display(double? screenSize, int? numberOfColors)
        {
            this.Size = screenSize;
            this.NumberOfColors = numberOfColors;
        }

        //Properties
        public double? Size { get; set; }

        public int? NumberOfColors { get; set; }
    }
}
