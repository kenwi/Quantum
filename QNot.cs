using System;

namespace Quantum
{
    public class QNot : QBit
    {
        public QNot(IQBit bit) : base(bit.Probability, bit.State)
        {
            Console.WriteLine($"Applying Quantum Not to {this}");
            /*
            x = 1 |0>
            not(x)
            x = 1 |1>
            */
            if (State == 1)
                State = 0;
            else
            {
                State = 1;
            }
        }

        public QNot() : base(0.0f, 0.0)
        {

        }
    }
}