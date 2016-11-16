namespace Quantum
{
    public class Complex
    {
        private double _r;
        private double _i;

        public double Real
        {
            get { return _r; }
            set { _r = value; }
        }

        public double Imaginary
        {
            get { return _i; }
            set { _i = value; }
        }

        public Complex(double r, double i)
        {
            _r = r;
            _i = i;
        }
    }
}