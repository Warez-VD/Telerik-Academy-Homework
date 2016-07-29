namespace LINQ.MyTimer
{
    using System;

    public class Subscriber
    {
        public Subscriber(string id, Timer t1)
        {
            this.ID = id;
            t1.Changed += HandleEvent;
        }

        public string ID { get; private set; }


        private void HandleEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(this.ID + " received time: {0}", e.Msg);
        }
    }
}
