using System.ComponentModel;

namespace Contabancaria
{
    public class Program
    {   
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            int opcao;
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
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Criar Conta \n\n");

                        break;
                    case 2:
                        Console.WriteLine("Listar todas as Contas - por número\n\n");

                        break;
                    case 3:
                        Console.WriteLine("Consulta dados da Conta - por número\n\n");

                        break;
                    case 4:
                        Console.WriteLine("Atualizar dados da Conta\n\n");

                        break;
                    case 5:
                        Console.WriteLine("Apagar a Conta\n\n");

                        break;
                    case 6:
                        Console.WriteLine("Saque\n\n");

                        break;
                    case 7:
                        Console.WriteLine("Depósito\n\n");

                        break;
                    case 8:
                        Console.WriteLine("Transferência entre Contas\n\n");

                        break;
                    case 9:
                        Console.WriteLine("\nOpção Inválida!\n");
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
        }
    }
}