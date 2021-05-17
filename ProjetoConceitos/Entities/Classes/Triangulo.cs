using System;

namespace ProjetoConceitos
{
    public class Triangulo 
    {
        private double _ladoA { get; set; }
        private double _ladoB { get; set; }
        private double _ladoC { get; set; }

        public Triangulo(double a, double b, double c)
        {
            this._ladoA = a;
            this._ladoB = b;
            this._ladoC = c;
        }

        public double CalcularArea()
        {
            double p = (_ladoA + _ladoB + _ladoC) / 2;
            return Math.Sqrt(p * (p - _ladoA) * (p - _ladoB) * (p - _ladoC));
        }

        public void ApresentaArea()
        {
            Console.WriteLine($"Area = {CalcularArea():f4}");        
        }
    }
}
