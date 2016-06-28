using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaX = 0;
            double somaY = 0;
            int n = int.Parse(Console.ReadLine());
            List<Ponto> pontos = new List<Ponto>();
            
            for( int i = 0; i < n; i++)
            {
                Ponto ponto = new Ponto();
                pontos.Add(ponto);
                pontos[i].X = double.Parse(Console.ReadLine());
                pontos[i].Y = double.Parse(Console.ReadLine());
                somaX += pontos[i].X;
                somaY += pontos[i].Y;

            }

            Console.WriteLine("{0} e {1}", somaX / n, somaY / n);


            


            
        }
    }
}
