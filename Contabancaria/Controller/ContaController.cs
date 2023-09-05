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
            var buscarConta = BuscarNaCollection(conta.GetNumero());

            if (buscarConta is not null)
            {
                var index = ListaContas.IndexOf(buscarConta);

                ListaContas[index] = conta;

                Console.WriteLine($"A conta número {conta.GetNumero()} foi atualizada com sucesso! ");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Conta {numero} não foi encontrada!");

                Console.ResetColor();
            }
            
        }

        public void Cadastrar(Conta conta)
        {
            ListaContas.Add(conta);
            Console.WriteLine($"A Conta {conta.GetNumero()} foi criada com sucesso!");
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (ListaContas.Remove(conta) == true)
                    Console.WriteLine($"A Conta {numero} foi apagada com sucesso");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Conta {numero} não foi encontrada!");

                Console.ResetColor();
            }
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
            var conta = BuscarNaCollection(numero);

            if(conta is not null)
                conta.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Conta {numero} não foi encontrada!");

                Console.ResetColor();
            }
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

        //Método para buscar um Objeto Conta especifico
        public Conta? BuscarNaCollection (int numero)
        {
            foreach (var conta in ListaContas)
            {
                if (conta.GetNumero() == numero) 
                    return conta;
            }

            return null;
        }


        public void ListarTodasa()
        {
            throw new NotImplementedException();
        }
    }
}
