using System.Security.Cryptography.X509Certificates;

namespace Projeto_Conta_Bancaria;

public class Conta
{
    public int Id_Conta;
    public decimal Saldo;
    public decimal Limite_Debito;
    public decimal saque;
    public decimal deposito;
    public string[] extrato;


    public Conta(int id_Conta, decimal saldo, decimal limite_Debito)
    {
        Id_Conta = id_Conta;
        Saldo = saldo;
        Limite_Debito = limite_Debito;

    }

    public void Sacar(decimal saque)
    {
        {

            //sacar

            if (saque > Limite_Debito)
                Console.WriteLine("o valor nao esta disponivel");
            else
            {
                Saldo -= saque;
                extrato = [($"saldo:  {Saldo} - Saque: {saque}")];
            }

        }

    }
    public void depositar(decimal deposito)
    {

        Saldo += deposito;
        extrato=[($"Depósito: +{deposito} | Saldo Atual: {Saldo}")];

    }

    public void ConsultarSaldo(decimal saldo)
    {
        Console.WriteLine(saldo);
    }

    public void transferirSaldo(Conta conta2, decimal valor)
    {
        Saldo -= valor;
        conta2.Saldo += valor;
       

    }


}
