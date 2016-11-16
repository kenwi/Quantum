using System;
using System.Runtime.InteropServices;

namespace Classical
{
    public class AndGate<T> : Gate<T>
    {
        public AndGate() : base()
        {

        }

        public new T[] Input
        {
            get; set;
        }

        /*
        public new T Output
        {
            get
            {
                T result;
                foreach (var x1 in Input)
                {

                }

                Console.WriteLine($"Output value is {1}");
                return (T)1;
            }
        }*/
    }
}