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
            Console.WriteLine($"A Conta número {conta.GetNumero()} foi criada com sucesso!");
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (ListaContas.Remove(conta) == true)
                    Console.WriteLine($"A Conta número {numero} foi apagada com sucesso");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Conta número {numero} não foi encontrada!");

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

        //Métodos Bancários 

        public void Sacar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (conta.Sacar(valor) == true)
                    Console.WriteLine($"O Saque da conta numero {numero} foi efetuada com sucesso!");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            var contaOrigem = BuscarNaCollection(numeroOrigem);
            var contaDestino = BuscarNaCollection(numeroDestino);

            if (contaOrigem is not null && contaDestino is not null)
            {
                if (contaOrigem.Sacar(valor) == true)
                {
                    contaDestino.Depositar(valor);
                    Console.WriteLine($"A Tranferencia foi efetuada com sucesso!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Conta de Origem e/ou Conta de Destino não foram encontradas!");
                Console.ResetColor();
            }
        }

        public void Depositar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                conta.Depositar(valor);
                    Console.WriteLine($"O Depósito da conta numero {numero} foi efetuada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }
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

        public void ListarTodasPorTitular(string titular)
        {
            var contasPorTitular = from conta in ListaContas
                                   where conta.GetTitular() .Contains(titular)
                                   select conta;

            contasPorTitular.ToList().ForEach(c => c.Visualizar());
        }
    }
}
