using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_dados = int.Parse(args[0]);
            int semente = int.Parse(args[1]);

            Random random = new Random(semente);
            int soma = 0;

            for (int i = 0; i < n_dados; i++)
            {
                int dado = random.Next(1,7);
                soma += dado;
            }

            Console.WriteLine(soma);
            }
    }
}
