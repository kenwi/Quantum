using System;

namespace Quantum
{
    public class QHadamard : QBit
    {
        public QHadamard(IQBit bit) : base(bit.Probability, bit.State)
        {
            //Console.WriteLine($"Applying Hadamard gate to {this}");
            //var t = new Complex(Math.Sqrt(0.5), 0);


            //Probability = 1 / Math.Sqrt(2);

            //Console.WriteLine($"Applying Hadamard gate to {this}");

            //Console.WriteLine(coeff);
        }

        public QBit[] Apply()
        {
            Console.WriteLine($"Applying Hadamard gate to {this}");
            var t = new Complex(Math.Sqrt(0.5), 0);

            var a = new QBit(0, t.Real);
            var b = new QBit(1, -t.Real);

            return new QBit[] {a, b};
        }
    }
}