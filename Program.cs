using System;

namespace Aula8Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
          CartaoCredito cielo = new CartaoCredito();
          System.Console.WriteLine("Digite a data do pagamento:");
          cielo.data = DateTime.Parse(Console.ReadLine());
          System.Console.WriteLine("Data digitada:"+cielo.data);
          cielo.limite = 1200;
          cielo.AumentarLimite(cielo.limite,400);
          cielo.pagar();
        }
    }
}
