namespace MainProgram
{
    using System;

    public class GSMTest
    {
        //Method
        public void DisplayInfo()
        {
            var array = new GSM[] 
            {
                new GSM("iPhone", "Apple", 1500, "David", new Battery("Sony", 2, 15, BatteryType.NiCd), new Display(5.5, 256)),
                new GSM("Galaxy", "Samsung", 1000, "John", new Battery("Philips", 4, 11, BatteryType.LiIon), new Display(3.5, 3500)),
                new GSM("C9", "Alcatel", 1500, "Matt", new Battery("Duracell", 13, 25, BatteryType.NiMH), new Display(4, 1500))
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(GSM.IPhone4S);
        } 
    }
}
