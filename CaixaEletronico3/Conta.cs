using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico3
{
    class Conta
    {
        public int numero;

        public string titular;

        public double saldo;

      public void Saca(double valor)
        {
            this.saldo -= valor;
        }
    }
}
