using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ponto
    {
        public double X {get; set;}
        public double Y { get; set; }
        public Ponto() {}
        public Ponto(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
