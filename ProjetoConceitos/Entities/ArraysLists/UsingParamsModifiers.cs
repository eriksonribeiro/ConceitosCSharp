using System;

namespace ProjetoConceitos
{
    public static class UsingParamsModifiers
    {
        public static void SumNumberWithParams(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum: {sum}");         
        }

        public static void TripleNumberWithRef(ref int number)
        {
            number = number * 3;
        }

        public static void TripleNumberWithOut(int number, out int resultNumber)
        {
            resultNumber = number * 3;
        }
    }
}
