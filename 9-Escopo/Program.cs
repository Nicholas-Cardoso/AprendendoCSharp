using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ResultInt(0);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string ResultString(string name)
        {
            var result = $"A sua variável é: {name} e o tamanho de caracteres é: {name.Length}";
            return result;
        }

        public static int ResultInt(int numberBox)
        {
            if (numberBox <= 5)
            {
                Console.WriteLine($"{numberBox}");
                return ResultInt(++numberBox);
            }
            else
            {
                return numberBox;
            }
        }
    }
}
