namespace LINQ.MyTimer
{
    using System;
    using System.Diagnostics;

    public delegate void ChangedEventHandler<CustomEventAgrs>(object sender, CustomEventArgs e);

    public class Timer
    {
        public delegate void MyDelegate();

        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        public int Seconds { get; private set; }

        public void InvokeAgain()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var del = new MyDelegate(PrintTime);

            while (true)
            {
                if (watch.Elapsed.Seconds != this.Seconds)
                {
                    continue;
                }

                del.Invoke();
                watch.Restart();
                OnChanged(new CustomEventArgs("Called by event"));
            }
            
        }

        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString() + " called by delegate");
        }

        protected virtual void OnChanged(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = Changed;

            if (handler != null)
            {
                e.Msg = DateTime.Now.ToLongTimeString().ToString();
                handler(this, e);
            }
        }

        public event EventHandler<CustomEventArgs> Changed;
    }
}
