namespace MainProgram
{
    using System;
    
    public class CallHistoryTest
    {
        //Method
        public void TestCallHistory()
        {
            var phone = new GSM("iPhone", "Apple", 1500, "Rosi", new Battery("Sony", 2, 15, BatteryType.NiCd), new Display(5.5, 256));

            phone.AddCall(new Call(new DateTime(2016, 6, 10, 10, 43, 25), "+359 88 6295 197", 30));
            phone.AddCall(new Call(new DateTime(2016, 6, 10, 8, 35, 12), "+359 88 6295 197", 12));
            phone.AddCall(new Call(new DateTime(2016, 6, 10, 5, 55, 11), "+359 88 6295 197", 125));

            Console.WriteLine(phone.CallHistoryInformation());
            Console.WriteLine("Total price: {0:C}", phone.TotalPrice(0.37m));
            
            phone.RemoveLongestCall();
            Console.WriteLine("Total price: {0:C}", phone.TotalPrice(0.37m));
            phone.ClearCalls();

            Console.WriteLine(phone.CallHistoryInformation());
        }
    }
}
