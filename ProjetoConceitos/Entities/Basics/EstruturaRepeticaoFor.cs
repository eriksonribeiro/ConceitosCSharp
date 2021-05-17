using System;

namespace ProjetoConceitos
{
    public static class EstruturaRepeticaoFor
    {
        public static void MostrarNumerosImpares()
        {
            int number = Entrada.RetornaInteiro();

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 > 0)
                    Console.WriteLine($"{i}");
            }
        }

        public static void Intervalo()
        {
            int n = Entrada.RetornaInteiro();
            int cIn = 0;
            int cOut = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe um numero");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                    cIn++;
                else
                    cOut++;
            }

            Console.WriteLine($"{cIn} in\n{cOut} out");

        }

        public static void MediaPonderada()
        {
            int n = Entrada.RetornaInteiro();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe três numero");
                string[] line = Console.ReadLine().Split(' ');

                double a = double.Parse(line[0]) * 2.0;
                double b = double.Parse(line[1]) * 3.0;
                double c = double.Parse(line[2]) * 5.0;

                double total = (a + b + c) / 10.0;

                Console.WriteLine(total.ToString("F1"));
            }

        }

        public static void PodeDivir()
        {
            int n = Entrada.RetornaInteiro();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe dois numero");
                string[] line = Console.ReadLine().Split(' ');

                double a = double.Parse(line[0]);
                double b = double.Parse(line[1]);

                if(b == 0)
                    Console.WriteLine("Divisão Impossivel");
                else
                    Console.WriteLine($"{a/b}");
            }

        }

        public static void Fatorial()
        {
            int n = Entrada.RetornaInteiro();
            int fator = n;

            for (int i = 1; i < n; i++)
            {
                if (n == 0)
                    fator = 1;

                fator = fator * (n - i);
            }

            Console.WriteLine($"{fator}");
        }

    }
}
