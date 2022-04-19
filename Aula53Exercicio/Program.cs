using System;

namespace Aula53Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Digite o valor do Pedido: R$ ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("CLiente Vip? (s/n): ");
            char cliente = char.Parse(Console.ReadLine().ToLower());
            Pedido ped = new Pedido(valor, cliente);
            Console.WriteLine(ped);
        }
    }
}
