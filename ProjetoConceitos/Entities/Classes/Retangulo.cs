using System;

namespace ProjetoConceitos
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return Largura+Largura+Altura+Altura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Largura,2));
        }
    }
}
