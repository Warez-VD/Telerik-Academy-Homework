namespace LINQ.MyTimer
{
    using System;

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            this.Msg = s;
        }

        public string Msg { get; set; }
    }
}
