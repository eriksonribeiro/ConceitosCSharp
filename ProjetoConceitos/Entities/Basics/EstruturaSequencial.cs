using System;

namespace ProjetoConceitos
{
    public static class EstruturaSequencial
    {
        public static void Soma()
        {
            int numberOne = Entrada.RetornaInteiro();
            int numberTwo = Entrada.RetornaInteiro();
            Console.WriteLine($"Soma = {numberOne+numberTwo}");
        }
        public static void CalculaAreaCirculo()
        {
            double raio = Entrada.RetornaDouble();
            Console.WriteLine($"Área = {Math.PI * Math.Pow(raio, 2):F4}");
        }
        public static void MostrarDiferença()
        {
            int a = Entrada.RetornaInteiro();
            int b = Entrada.RetornaInteiro();
            int c = Entrada.RetornaInteiro();
            int d = Entrada.RetornaInteiro();

            Console.WriteLine($"Diferença = {a*b-c*d}");
        }
        public static void CalculaValorAPagar()
        {
            int qtd1, qtd2;
            double preco1, preco2;

            Console.WriteLine("Informe o Código, a quantidade e o valor unitário de uma peça:");
            string[] item1 = Console.ReadLine().Split(' ');

            qtd1 = int.Parse(item1[1]);
            preco1 = double.Parse(item1[2]);


            Console.WriteLine("Informe o Código, a quantidade e o valor unitário de uma peça:");
            string[] item2 = Console.ReadLine().Split(' ');
            qtd2 = int.Parse(item2[1]);
            preco2 = double.Parse(item2[2]);

            Console.WriteLine($"Valor a pagar: R$ {qtd1*preco1+qtd2*preco2}");
        }
        public static void CalculaArea()
        {
            string[] lista = Entrada.RetornaArrayStringToDouble();

            double a = double.Parse(lista[0]);
            double b = double.Parse(lista[1]);
            double c = double.Parse(lista[2]);

            Console.WriteLine($"Triangulo = {a*c/2:F3}");
            Console.WriteLine($"Área =  {Math.PI * Math.Pow(c, 2):F3}");
            Console.WriteLine($"Trapézio = {((b+a)*c/2):F3}");
            Console.WriteLine($"Quadrado = {Math.Pow(b, 2):F3}");
            Console.WriteLine($"Retângulo = {a*b:F3}");

        }

    }
}
