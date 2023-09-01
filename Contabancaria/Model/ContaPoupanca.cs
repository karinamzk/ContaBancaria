using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Contabancaria.Model
{
    internal class ContaPoupanca : Conta

    {
        private int aniversario;
        public ContaPoupanca(int numero, int agencia, int tipo, decimal saldo, string titular, int aniversario) 
            : base(numero, agencia, tipo, saldo, titular)
        {
            this.aniversario = aniversario;
        }

        public int GetAniversario()
        {
            return this.aniversario;
        }

        public void SetAniversario(int aniversario)
        {
            this.aniversario=aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversario da Conta: {this.aniversario}");
        }

    }
}
