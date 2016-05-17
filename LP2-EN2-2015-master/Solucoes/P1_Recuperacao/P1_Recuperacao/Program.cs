using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_Recuperacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Q2();
        }
        
        static void Q1(string[] args)
        {
            int[] v = { 5, 1, 4, 2, 7, 8, 3, 6 };
            int aux;

            for(int i = 7; i >= 4; i--)
            {
                aux = v[i];
                v[i] = v[8 - 1 - i];
                v[8 - 1 - i] = aux;
            }
            
            v[2] = v[0];
            v[v[2]] = v[v[1]];

            for (int i = 0; i < 8; i++)
                Console.Write("{0} ", v[i]);

            // Situação do array v ao término da execução do programa: 6 3 6 7 2 4 7 5

            /* Como um while, este for seria reescrito da seguinte maneira:
             * 
             * int i = 7;
             * while(i >= 4)
             * {
             *     aux = v[i];
             *     v[i] = v[8 - 1 - i];
             *     v[8 - 1 - i] = aux;
             *     i--;
             * }
             * 
             */
        }

        static void Q2()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> v = new List<int>();

            for (int i = 1; i <= n; i ++)
            {
                if (n % i == 0)
                {
                    v.Add(i);
                }
            }

            for (int i = 0; i < v.Count; i++)
                Console.WriteLine(v[i]);

            /* Este programa serve para descobrir os divisores de um número N informado pelo usuário.
             * Ele poderia ser escrito de forma mais eficiente, pois utiliza uma lista desnecessária. 
             * É possível imprimir os divisores de N conforme eles são encontrados pelo programa.
             * 
             * int n = int.Parse(Console.ReadLine());

             * for (int i = 1; i <= n; i ++)
             * {
             *     if (n % i == 0)
             *     {
             *         Console.WriteLine(i);
             *     }
             * }
             * 
             * Uma outra melhoria possível seria fazer o for rodar somente para i <= n/2, já que o maior divisor de um número
             * é no máximo, a sua metade (números pares)
             * 
             */
        }

        static void Q3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            int p = int.Parse(Console.ReadLine());

            int maiorSoma = int.MinValue;

            for (int i = n % p; i < n; i += p)
            {
                int soma = 0;
                for (int j = i; j < i + p; j++)
                {
                    soma += v[j];
                }

                if (soma > maiorSoma)
                    maiorSoma = soma;
            }

            Console.WriteLine(maiorSoma);
        }

    }
}
