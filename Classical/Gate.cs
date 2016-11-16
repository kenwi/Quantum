using System;

namespace Classical
{
    public class Gate<T>
    {
        private T _output;
        private T _input;

        public T Input
        {
            get { return _input; }
            set
            {
                Console.WriteLine($"Set Input to {value}");
                _input = value;
            }
        }

        public T Output
        {
            get
            {
                Console.WriteLine($"Output value is {_input}");
                return _input;
            }
        }
    }
}