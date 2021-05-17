using System;

namespace ProjetoConceitos
{
    public static class EstruturaCondicional
    {
        public static void NegativoOrPositivo()
        {
            int number = Entrada.RetornaInteiro();

            if(number < 0)
                Console.WriteLine("Negativo");
            else
                Console.WriteLine("Não Negativo");
        }

        public static void ImparOrPar()
        {
            int number = Entrada.RetornaInteiro();

            if (number % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Ímpar");
        }

        public static void Multiplos()
        {
           string[] entrada = Entrada.RetornaArrayStringToInt();
           int a = int.Parse(entrada[0]);
           int b = int.Parse(entrada[1]);

            if ((a % b == 0) || (b % a == 0))
                Console.WriteLine("São Multiplos");
            else
                Console.WriteLine("Não Multiplos");
  
        }

        public static void DuracaoJogo()
        {
            string[] entrada = Entrada.RetornaArrayStringToInt();

            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);
            int c;

            if (a < b)
                c = b - a;
            else
                c = 24 - a + b;

            Console.WriteLine($"O jogo durou {c} hora (s).");
        }

        public static void Conta()
        {
            Console.WriteLine("Informe o lanche a quantidade");
            string[] entrada = Console.ReadLine().Split(' ');

            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            if (a == 1)
                Console.WriteLine($"Total R$ {b * 4.00:F2}");
            else if (a == 2)                             
                Console.WriteLine($"Total R$ {b * 4.50:F2}");
            else if (a == 3)                             
                Console.WriteLine($"Total R$ {b * 5.00:F2}");
            else if (a == 4)                            
                Console.WriteLine($"Total R$ {b * 2.00:F2}");
            else                                         
                Console.WriteLine($"Total R$ {b * 1.50:F2}");
        }

        public static void Intervalo()
        {
            double number = Entrada.RetornaDouble();

            if ((number < 0) ||(number > 100))
                Console.WriteLine("Fora de intervalo");
            else if (number <= 25)
                Console.WriteLine( "Intervalo [0,25]");
            else if (number<=50)
                Console.WriteLine("Intervalo (25,50]");
            else if (number <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else
                Console.WriteLine("Intervalo (75,100]");
        }

        public static void Coordenadas()
        {
            Console.WriteLine("Informe duas coordenadas");
            string[] entrada = Console.ReadLine().Split(' ');

            double x = double.Parse(entrada[0]);
            double y = double.Parse(entrada[1]);

            if ((x == 0)&&(y==0))
                Console.WriteLine("Origem");
            else if (x == 0)
                Console.WriteLine("Eixo X");
            else if (y == 0)
                Console.WriteLine("Eixo y");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else
                Console.WriteLine("Q3");
        }

        public static void CalculoImposto()
        {
            double number = Entrada.RetornaDouble();
            double resultado;

            if (number >= 0.00 && number <= 2000.00)
                resultado = 0.00;
            else if (number <= 3000.00)
                resultado = ((number - 2000.00) * 0.08);
            else if (number <= 4500.00)
                resultado = (1000.00 * 0.08 + (number - 3000.00) * 0.18);
            else
                resultado = (1000.00 * 0.08 + 1500.00 * 0.18 + (number - 4500.00) * 0.28);

            if (resultado == 0)
                Console.WriteLine("Isento");
            else
            Console.WriteLine($"R$ {resultado:F2}");
        }
    }
}
