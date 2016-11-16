using  System;
using System.Collections.Generic;

namespace Quantum
{
    public class QRegister
    {
        private List<QBit> _qBits;

        public int QbitCount => _qBits.Count;
        public int Amplitudes => (1 << QbitCount);

        public QRegister()
        {
            _qBits = new List<QBit>();
        }

        public void Add(QBit bit)
        {
            Console.WriteLine($"Adding qbit {bit} to register");
            _qBits.Add(bit);
        }

        public void Print()
        {
            Console.WriteLine("Register contents:");
            _qBits.ForEach(Console.WriteLine);
        }

        public void Measure()
        {
            Console.WriteLine("Measuring register");

            double result = 0.0;
            for (int i = 0; i < QbitCount; i++)
            {
                result += Measure(i);

                var measuredBit = _qBits[i];
                Console.WriteLine($"{measuredBit} result: {result}" );
            }
        }

        private double Measure(int index)
        {
            double p0 = ProbabilityFor0(index);

            var masuredBit = MeasureMentResult(p0);


            return p0;
        }

        static readonly Random _random = new Random();
        private static int MeasureMentResult(double p0)
        {
            var value = _random.NextDouble();
            var measuredBit = value < p0 ? 0 : 1;
            return measuredBit;
        }

        public double ProbabilityFor0(int index)
        {
            double result = 0.0d;

            for (int i = 0; i < QbitCount; i++)
            {
                if (Is(0, i, index))
                {
                    result += _qBits[i].Magnitude * _qBits[i].Magnitude;
                }
            }

            return result;
        }

        private bool Is(int toCompare, int number, int bitIndex)
        {
            return toCompare == BitAt(number, bitIndex);
        }

        private int BitAt(int number, int index)
        {
            index = QbitCount - index -1;
            int mask = 1 << index;
            int t = (number & mask);
            t = t >> index;
            return t;
        }
    }
}
