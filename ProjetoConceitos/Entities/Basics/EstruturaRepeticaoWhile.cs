using System;

namespace ProjetoConceitos
{
    public static class EstruturaRepeticaoWhile
    {
        public static void Senha()
        {
            while (true)
            {
                Console.WriteLine("Informe a senha");
                int senha = int.Parse(Console.ReadLine());

                if (senha != 2002)
                    Console.WriteLine("Senha Inválida");
                else
                    break;
            }
            Console.WriteLine("Acesso Permitido");
        }

        public static void Coordenadas()
        {
            while (true)
            {
                Console.WriteLine("Informe duas coordenadas");
                string[] coordenadas = Console.ReadLine().Split(' ');

                int x = int.Parse(coordenadas[0]);
                int y = int.Parse(coordenadas[1]);

                if (x == 0 || y == 0)
                    break;
                else if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Quarto");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo");
                else
                    Console.WriteLine("Terceiro");
            }
        }

        public static void PostoCombustivel()
        {
            int diesel = 0;
            int alcool = 0;
            int gasolina = 0;

            while (true)
            { 
               Console.WriteLine("Informe o Combustivel desejado");
               int exit = int.Parse(Console.ReadLine());
               
               if (exit == 1)
                   alcool++;
               else if (exit == 2)
                   gasolina++;
               else if (exit == 3)
                   diesel++;
               else if (exit == 4)
               {
                   Console.WriteLine("Muito Obrigado");
                   Console.WriteLine($"Alcool {alcool}" );
                   Console.WriteLine($"Gasolina {gasolina}");
                   Console.WriteLine($"Diesel {diesel}");
                   break;
               }
               else
                  Console.WriteLine("");
            }

        }
    }
}
