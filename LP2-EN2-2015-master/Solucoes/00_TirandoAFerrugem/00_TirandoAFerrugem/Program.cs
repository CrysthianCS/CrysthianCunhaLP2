using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00_TirandoAFerrugem
{
    class Program
    {
        static void Main(string[] args)
        {
            //SolucaoComArray();
            SolucaoSemArray();
        }

        public static void SolucaoComArray()
        {
            List<double> nums = new List<double>();
            double n = double.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n > 0)
                    nums.Add(n);
                else
                    Console.WriteLine("Ignorado");

                n = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Média: {0}", nums.Average());
        }

        public static void SolucaoSemArray()
        {
            double soma = 0, n;
            int qtd = 0;
            
            n = double.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n > 0)
                {
                    soma += n;
                    qtd += 1;
                }
                else
                {
                    Console.WriteLine("Ignorado");
                }

                n = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Média: {0}", soma / qtd);
        }
    }
}
