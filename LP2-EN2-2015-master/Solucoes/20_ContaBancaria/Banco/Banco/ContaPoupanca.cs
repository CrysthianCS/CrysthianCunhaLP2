using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : ContaBancaria
    {
        public int DiaRendimento { get; set; }

        public double ClacularNovoSaldo(double taxaPorcento)
        {
            Saldo *= (1 + taxaPorcento / 100);
            return Saldo;
        }
    }
}
