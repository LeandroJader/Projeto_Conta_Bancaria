using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Projeto_Conta_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1,1500,700);
            Conta conta2 = new Conta(2, 100, 700);

            conta1.Sacar(200);
            
            conta1.depositar(100);

            conta1.ConsultarSaldo(conta1.Saldo);


            conta1.transferirSaldo(conta2,200);
            Console.WriteLine($"o saldo da conta agora e de  {conta2.Saldo}");
            Console.ReadLine();
    }
      


    }
}
