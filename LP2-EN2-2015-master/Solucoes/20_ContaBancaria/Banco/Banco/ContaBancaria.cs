using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaBancaria
    {
        public string Cliente { get; set; }
        public string NumConta { get; set; }
        public double Saldo { get; set; }

        public virtual bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }

        public double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }
    }
}
