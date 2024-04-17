using System;


namespace banheira
{
    class Program
    {
        static void Main(string[] args)
        {
            double instalacao= 300.00;
            double limpeza = 150.00;
            double manutencao = 499.99;
            double desconto = 50.00;

            double valorTotal= instalacao + limpeza + manutencao - desconto;

            Console.WriteLine("o valor que o cliente vai pagar é " + valorTotal);
       
        }
    }
}
