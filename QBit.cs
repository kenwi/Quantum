using System;

namespace Quantum
{
    public class QBit : IQBit
    {
        private Complex _q;

        public double State
        {
            get { return _q.Real; }
            set
            {
                Console.WriteLine($"Setting state to {value}");
                _q.Real = value;
            }
        }

        public double Magnitude => Math.Sqrt(_q.Real * _q.Real + _q.Imaginary * _q.Imaginary);

        public double Probability
        {
            get { return _q.Imaginary; }
            set
            {
                Console.WriteLine($"Setting probability to {value}");
                _q.Imaginary = value;
            }
        }

        public double Coefficient
        {
            get { return Probability; }
            set { Probability = value; }
        }

        public QBit(double probability, double state)
        {
            _q = new Complex(probability, state);
        }

        public override string ToString()
        {
            return $@"{Probability} |{State}>";
        }
    }
}