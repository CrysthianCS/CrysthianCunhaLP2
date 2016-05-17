using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao2();
            //Questao4();
            //Questao5();
        }

        static void Questao2()
        {
            int n = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            int x = 1;

            for (int i = 0; i < q; i++)
            {
                x *= n;
            }

            Console.WriteLine(x);
        }

        static void Questao4()
        {
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                int i = 1;
                int prod = i * (i + 1) * (i + 2);
                bool ehTriangular = false;

                while (prod <= n)
                {
                    if (prod == n)
                        ehTriangular = true;

                    i += 1;
                    prod = i * (i + 1) * (i + 2);
                }

                if (!ehTriangular)
                    Console.WriteLine("Não triangular: Não existe");
                else
                    Console.WriteLine("Triangular: {0}, {1} e {2}", i, i + 1, i + 2);

                n = int.Parse(Console.ReadLine());
            }
        }

        static void Questao5()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                bool ehPalindromo = true;

                string frase = Console.ReadLine();
                for (int j = 0; j <= frase.Length / 2 && ehPalindromo; j++)
                {
                    if (frase[j] != frase[frase.Length - j - 1])
                        ehPalindromo = false;
                }

                if (ehPalindromo)
                    Console.WriteLine("É palindromo");
                else
                    Console.WriteLine("Não é palindromo");
            }

        }
    }
}
