using System;

namespace Aula52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido
            {
                PedidoID = 1,
                DtPedido = DateTime.Today,
                DatePagamento = DateTime.Today.AddDays(45),
                Valor = 1500m
            };

            Console.WriteLine("Tipo do Campo Valor" +pedido.Valor.GetType());

            Console.WriteLine($"Pedido: {pedido.PedidoID}");
            Console.WriteLine($"Data do Pedido: {pedido.DtPedido:dd/MM/yyyy}");
            Console.WriteLine($"Data de Vencimento: {pedido.DateVencimento:dd/MM/yyyy}");
            Console.WriteLine($"Data de Pagamento: {pedido.DatePagamento:dd/MM/yyyy}");
            Console.WriteLine($"Dias em atraso: {pedido.DiasAtraso().TotalDays}");
            Console.WriteLine($"Valor: R$ {pedido.Valor:F2}");
            Console.WriteLine($"Multa: R$ {pedido.Multa:F2}");
            Console.WriteLine($"Total com Multa: R$ {(pedido.Valor + pedido.Multa):F2}");
            

            
        }
    }

    public class Pedido
    {
        public int PedidoID { get; set; }
        public DateTime DtPedido { get; set; }
        public DateTime DateVencimento => DtPedido.AddDays(30);
        public DateTime DatePagamento { get; set; }
        public TimeSpan DiasAtraso() => DatePagamento.Subtract(DateVencimento);
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10m;
        //campo calculado não é armazenado 
    }
}
