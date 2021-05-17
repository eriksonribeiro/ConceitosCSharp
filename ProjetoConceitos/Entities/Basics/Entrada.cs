using System;

namespace ProjetoConceitos
{
    public static class Entrada
    {
        public static int RetornaInteiro()
        {
            Console.WriteLine("Infome um número inteiro:");
            return int.Parse(Console.ReadLine());
        }

        public static double RetornaDouble()
        {
            Console.WriteLine("Infome um número double:");
            return double.Parse(Console.ReadLine());
        }

        public static string [] RetornaArrayStringToInt()
        {
            Console.WriteLine("Infome dois número inteiros separados por espaço:");
            return Console.ReadLine().Split(' ');
        }
        public static string[] RetornaArrayStringToDouble()
        {
            Console.WriteLine("Infome três número Double separados por espaço:");
            return Console.ReadLine().Split(' ');
        }
    }
}
