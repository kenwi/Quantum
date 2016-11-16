using System;
using System.Collections;
using System.Collections.Generic;

namespace Classical
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                var gate = new Gate<int> {Input = 1};
                var output = gate.Output;
            }

            {
                var input = new int[] {1, 1};
                var gate = new AndGate<int> {Input = input};
                var output = gate.Output;
            }

        }
    }
}


