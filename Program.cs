using System;

namespace Quantum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            var t = new QBit(1.0, 0.0);
            PrintState(t);

            IQBit t2 = new QNot(t);
            PrintState(t2);

            IQBit t3 = new QNot(t2);
            PrintState(t3);

            var t4 = new QHadamard(t3);
            var result = t4.Apply();

            PrintState( result[0]);
            PrintState( result[1]);
            */

            {
                var b = new QBit(1.0, 0.0);
                var gate = new QNot();

                PrintState(b);

                var register = new QRegister();
                register.Add(b);
                register.Print();
                register.Measure();
            }
        }

        private static void PrintState(IQBit bit)
        {
            Console.WriteLine("{Probability} |{State}>");
            Console.WriteLine(bit);
        }
    }
}