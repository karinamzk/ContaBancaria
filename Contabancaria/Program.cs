using Contabancaria.Controller;
using Contabancaria.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contabancaria
{
    public class Program
    {   
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {

            int opcao, agencia, tipo, aniversario;
            string? titular;
            decimal saldo, limite;

            ContaController contas = new();

            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero(), 123, 1, 100000000.00M, "Samantha", 1000.00m);
            contas.Cadastrar(cc1);

            ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 123, 2, 100000000, "Karina", 15);
            contas.Cadastrar(cp1);

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("            BANCO DO BRAZIL COM Z            ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("         1 - Criar Conta                     ");
                Console.WriteLine("         2 - Lista todas as Contas           ");
                Console.WriteLine("         3 - Buscar Conta por Numero         ");
                Console.WriteLine("         4 - Atualizar Dados da conta         ");
                Console.WriteLine("         5 - Apagar Conta                    ");
                Console.WriteLine("         6 - Sacar                           ");
                Console.WriteLine("         7 - Depositar                       ");
                Console.WriteLine("         8 - Transferir valores entre Contas ");
                Console.WriteLine("         9 - Sair                            ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("Entre com a opção desejada:                  ");
                Console.WriteLine("                                             ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {   
                    Console.BackgroundColor= ConsoleColor.Black;
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("\n Banco do Brazil com Z - O seu Futuro começa aqui!");
                    Sobre();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Conta \n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Número da Agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o nome do Titular: ");
                        titular = Console.ReadLine();

                        titular ??= string.Empty;

                        do
                        {
                            Console.WriteLine("Digite o tipo da Conta: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o Saldo da Conta: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o limite da Conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());

                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, saldo, titular, limite)); ;
                                break;
                            case 2:
                                Console.WriteLine("Digite o aniversario da Conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());

                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, saldo, titular, aniversario));
                                break;
                        }

                        KeyPress();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todas as Contas - por número\n\n");
                        Console.ResetColor();

                        contas.ListarTodas();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consulta dados da Conta - por número\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;   
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Saque\n\n");
                        Console.ResetColor();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Depósito\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Transferência entre Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;    
                }
            }

            static void Sobre()
            {
                Console.WriteLine("\n*************************************************");
                Console.WriteLine("Projeto Desenvolvido por: ");
                Console.WriteLine("Generation Brasil - generation@generation.org");
                Console.WriteLine("github/conteudoGeneration");
                Console.WriteLine("***************************************************");
         
            }

            static void KeyPress()
            {
                do
                {
                    Console.Write("\nPress Enter to continue!");
                    consoleKeyInfo = Console.ReadKey();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
        }
    }
}