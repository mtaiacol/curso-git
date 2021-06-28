using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_Ex01
{
    class ContaCorrente
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Deposito { get; private set; }

        public ContaCorrente(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public ContaCorrente(string titular, int numero, double deposito) : this(titular, numero)
        {
            // Deposito = deposito;
            FazerDeposito(deposito);
        }

        public void FazerDeposito(double deposito) => Deposito += deposito;

        public void FazerSaque(double deposito) => Deposito -= deposito + 5;

        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo R$ {Deposito}";
        }
    }
}
