using Contabancaria.Model;
using Contabancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabancaria.Controller
{
    public class ContaController : IContaRepository
    {
        private readonly List<Conta> ListaContas = new();
        int numero = 0;

        // Métodos do Crud
    
        public void Atualizar(Conta conta)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Conta conta)
        {
            ListaContas.Add(conta);
            Console.WriteLine($"A Conta {conta.GetNumero()} foi criada com sucesso!");
        }

        public void Deletar(int numero)
        {
            throw new NotImplementedException();
        }

        public void ListarTodas()
        {
            foreach(var conta in ListaContas)
            {
                conta.Visualizar();
            }
        }

        public void ProcurarPorNumero(int numero)
        {
            throw new NotImplementedException();
        }

        //Métodos Bancarios 

        public void Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }
         // Metodos Auxiliares

        public int GerarNumero()

        {
            return ++numero;
        }


        public void ListarTodasa()
        {
            throw new NotImplementedException();
        }
    }
}
