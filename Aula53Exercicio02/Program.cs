using System;

namespace Aula53Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o Valor da Conta: R$ ");
            double valor =  double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de pessoas na mesa: ");
            int qtdPessoas = int.Parse(Console.ReadLine()); 
            Restaurante conta = new Restaurante(valor, qtdPessoas);
            conta.Vaquinha();

        }
    }

    public class Restaurante
    {
        public double  Valor { get; set; }
        public int QtdMesa { get; set; }

        public Restaurante(double valor, int qtdMesa)
        {
            Valor = valor;
            QtdMesa = qtdMesa;
        }

        public void Vaquinha()
        {
            double vaquinha = Valor / QtdMesa;
            if(Valor % QtdMesa == 0)
            {
                Console.WriteLine("Cada pessoa vai pagar: R$ " + vaquinha.ToString("F2"));
                Console.WriteLine("Cada pessoa pagará " + (vaquinha / Valor * 100).ToString("F2") + "% da conta.");
            }
            else
            {
                Console.WriteLine("Cada pessoa vai pagar aproximadamente: R$ " + vaquinha.ToString("F2"));
                Console.WriteLine("Cada pessoa pagará aproximadamente: " + (vaquinha / Valor * 100).ToString("F2") + "% da conta.");
            }
         
        }
    }
}
