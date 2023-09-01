﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Contabancaria.Model
{
    public class ContaCorrente : Conta
    {
        private decimal limite;
        public ContaCorrente(int numero, int agencia, int tipo, decimal saldo, string titular, decimal limite) 
            : base(numero, agencia, tipo, saldo, titular)
        {
            this.limite = limite;
        }

        public decimal GetLimite() 
        {
            return limite;
        }

        public void SetLimite(decimal limite)
        {
            this.limite = limite;
        }
        /* Polimorfismo de Sobrescrita */
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }



        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Limite da Conta {this.limite}");
        }


    }
}
