using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaEspecial : ContaBancaria
    {
        public double Limite { get; set; }

        public override bool Sacar(double valor)
        {
            if (valor <= Saldo + Limite)
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }
    }
}
