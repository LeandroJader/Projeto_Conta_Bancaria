using System;

namespace Projeto_Conta_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(12, 1000, 500);
            Conta conta2 = new Conta(13, 700, 500);

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Consultar Saldo");
                Console.WriteLine("4 - Transferir");
                Console.WriteLine("5 - Exibir Extrato");
                Console.WriteLine("6 - Sair");
                Console.Write("Opção: ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor do saque: ");
                        decimal saque = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Escolha a conta (1 ou 2): ");
                        int escolhaSaque = Convert.ToInt32(Console.ReadLine());

                        if (escolhaSaque == 1)
                            conta1.Sacar(saque);
                        else if (escolhaSaque == 2)
                            conta2.Sacar(saque);
                        else
                            Console.WriteLine("Conta inválida!");

                        break;

                    case 2:
                        Console.Write("Digite o valor do depósito: ");
                        decimal deposito = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Escolha a conta (1 ou 2): ");
                        int escolhaDeposito = Convert.ToInt32(Console.ReadLine());

                        if (escolhaDeposito == 1)
                            conta1.Depositar(deposito);
                        else if (escolhaDeposito == 2)
                            conta2.Depositar(deposito);
                        else
                            Console.WriteLine("Conta inválida!");

                        break;

                    case 3:
                        Console.Write("Escolha a conta para consultar saldo (1 ou 2): ");
                        int escolhaSaldo = Convert.ToInt32(Console.ReadLine());

                        if (escolhaSaldo == 1)
                            Console.WriteLine($"Saldo da Conta #12: R$ {conta1.Saldo:F2}");
                        else if (escolhaSaldo == 2)
                            Console.WriteLine($"Saldo da Conta #13: R$ {conta2.Saldo:F2}");
                        else
                            Console.WriteLine("Conta inválida!");

                        break;

                    case 4:
                        Console.Write("Digite o valor para transferência: ");
                        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Transferir de qual conta? (1 ou 2): ");
                        int contaOrigem = Convert.ToInt32(Console.ReadLine());

                        if (contaOrigem == 1)
                            conta1.Transferir(conta2, valorTransferencia);
                        else if (contaOrigem == 2)
                            conta2.Transferir(conta1, valorTransferencia);
                        else
                            Console.WriteLine("Conta inválida!");

                        break;

                    case 5:
                        Console.Write("Escolha a conta para exibir o extrato (1 ou 2): ");
                        int escolhaExtrato = Convert.ToInt32(Console.ReadLine());

                        if (escolhaExtrato == 1)
                            conta1.ExibirExtrato();
                        else if (escolhaExtrato == 2)
                            conta2.ExibirExtrato();
                        else
                            Console.WriteLine("Conta inválida!");

                        break;

                    case 6:
                        Console.WriteLine("Saindo...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
