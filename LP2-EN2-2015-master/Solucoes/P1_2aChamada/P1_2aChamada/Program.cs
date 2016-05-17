using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_2aChamada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] seq = new int[n];

            // Leitura dos dados
            for (int i = 0; i < n; i++)
            {
                seq[i] = int.Parse(Console.ReadLine());
            }

            // Achando o menor divisor, que será a qtd máxima por grupo
            int menorDivisor = -1;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    menorDivisor = i;
                    break;
                }
            }

            // Exibindo os subgrupos, caso haja
            if (menorDivisor == -1)
                Console.WriteLine("Não é possível criar grupos");
            else
            {
                Console.WriteLine("{0} grupos:", menorDivisor);
                int qtdGrupos = n / menorDivisor;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", seq[i]);
                    if ((i + 1) % qtdGrupos == 0)
                        Console.WriteLine("");
                }
            }
        }
    }
}
