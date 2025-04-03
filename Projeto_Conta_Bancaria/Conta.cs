using System;
using System.Collections.Generic;

namespace Projeto_Conta_Bancaria
{
    public class Conta
    {
        public int Id_Conta { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal Limite_Debito { get; private set; }
        private List<string> extrato;

        public Conta(int id_Conta, decimal saldo, decimal limite_Debito)
        {
            Id_Conta = id_Conta;
            Saldo = saldo;
            Limite_Debito = limite_Debito;
            extrato = new List<string>();
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Erro: Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                extrato.Add($"Débito de R$ {valor:F2}");
                Console.WriteLine("Saque realizado com sucesso!");
            }
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            extrato.Add($"Crédito de R$ {valor:F2}");
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void Transferir(Conta destino, decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Erro: Saldo insuficiente para transferência.");
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                extrato.Add($"Transferência de R$ {valor:F2} para Conta {destino.Id_Conta}");
                Console.WriteLine("Transferência realizada com sucesso!");
            }
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"\nExtrato da Conta #{Id_Conta}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Movimentações:");
            foreach (var item in extrato)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}\n");
        }
    }
}
