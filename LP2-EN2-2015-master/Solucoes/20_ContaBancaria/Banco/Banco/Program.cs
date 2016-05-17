using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            ContaEspecial especial = new ContaEspecial();
            ContaPoupanca poupanca = new ContaPoupanca();

            Console.WriteLine("Conta Bancária");
            Console.Write("Cliente: ");
            conta.Cliente = Console.ReadLine();
            Console.Write("Nro da Conta: ");
            conta.NumConta = Console.ReadLine();
            Console.Write("Saldo: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            /*Console.WriteLine("Conta Especial");
            Console.Write("Cliente: ");
            especial.Cliente = Console.ReadLine();
            Console.Write("Nro da Conta: ");
            especial.NumConta = Console.ReadLine();
            Console.Write("Saldo: ");
            especial.Saldo = double.Parse(Console.ReadLine());
            Console.Write("Limite: ");
            especial.Limite = double.Parse(Console.ReadLine());

            Console.WriteLine("Conta Poupança");
            Console.Write("Cliente: ");
            poupanca.Cliente = Console.ReadLine();
            Console.Write("Nro da Conta: ");
            poupanca.NumConta = Console.ReadLine();
            Console.Write("Saldo: ");
            poupanca.Saldo = double.Parse(Console.ReadLine());
            Console.Write("Dia do rendimento: ");
            poupanca.DiaRendimento = int.Parse(Console.ReadLine());*/

            Console.WriteLine("Saldo na conta: R$ {0:N}", conta.Saldo);
            Console.Write("Valor a depositar: ");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Saldo na conta: R$ {0:N}", conta.Saldo);
            Console.Write("Valor a sacar: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Saldo na conta: R$ {0:N}", conta.Saldo);

            //Operações com conta poupança e conta especial......

        }
    }
}
