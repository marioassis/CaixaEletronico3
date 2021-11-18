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
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
        
        public bool VerificaSaldo(Conta conta)
        {
            if(conta.saldo => 0) return true;

            return false;               
        }
    }

}
