﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Contabancaria.Model
{
    public abstract class Conta
    {
        /*Atributo*/
        private int numero;
        private int agencia;
        private int tipo;
        private decimal saldo;
        private string titular = string.Empty;


        /*Método Construtor*/
        public Conta(int numero, int agencia, int tipo, decimal saldo, string titular)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.tipo = tipo;
            this.saldo = saldo;
            this.titular = titular;
        }

        // Polimorfismo de Sobrecarga
        public Conta() { }

        // Métodos Get (exibir) e Set (alterar)
        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetAgencia()
        {
            return agencia;
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string titular)
        {
            this.titular = titular;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(decimal saldo)
        {
            this.saldo = saldo;
        }
        public virtual bool Sacar(decimal valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.SetSaldo(this.saldo - valor);
            return true;
        }

        public void Depositar(decimal valor)
        {
            this.SetSaldo(this.saldo + valor);
        }

        public virtual void Visualizar()
        {
            string tipo = "";

            switch (this.tipo)
            {
                case 1:
                    tipo = "Conta Corrente";
                    break;
                case 2:
                    tipo = "Conta Poupança";
                    break;
            }
            Console.WriteLine("********************************");
            Console.WriteLine("Dados da Conta");
            Console.WriteLine("********************************");
            Console.WriteLine($"Número da conta : {this.numero}");
            Console.WriteLine($"Número da agência : {this.agencia}");
            Console.WriteLine($"Tipo da conta : {tipo}");
            Console.WriteLine($"Saldo da conta : {this.saldo}");
            Console.WriteLine($"Titular da conta : {this.titular}");

        }

    }
}
