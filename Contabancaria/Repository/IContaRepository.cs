﻿using Contabancaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabancaria.Repository
{
    public interface IContaRepository
    {

        // Métodos do CRUD
        public void ProcurarPorNumero(int numero);
        public void ListarTodas();
        public void Cadastrar(Conta conta);
        public void Atualizar(Conta conta);
        public void Deletar(int numero);

        public void ListarTodasPorTitular(string titular);

        //Métodos Bancários 

        public void Sacar(int numero, decimal valor);
        public void Depositar(int numero, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);
    }
}
