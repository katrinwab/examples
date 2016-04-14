using System;

namespace examples
{
    public class WrongLengthException : Exception
    {
        public WrongLengthException()
            : base(_message)
        {}

        private const string _message = "Неверная длина сторон";
    }
    public class Program
    {
        public static double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (Double.IsNaN(res))
                throw new WrongLengthException();
            return res;
        }

        static void Main(string[] args)
        {
        }
    }
}
