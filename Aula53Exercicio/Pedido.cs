using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio
{
    internal class Pedido
    {
        public double ValorPedido { get; private set; }
        public char  ClienteVip { get; set; }

        public Pedido(double valorPedido, char clientevip )
        {
            ValorPedido = valorPedido;
            ClienteVip = clientevip;
        }

        public double ValorTotalPedido()
        {
            if (ClienteVip == 's')
            {
                return ValorPedido - (ValorPedido * 0.15);
            }
            else
            {
                return ValorPedido;
            }
        }

        public override string ToString()
        {
            if(ValorPedido == ValorTotalPedido())
            {
               return "Cliente Comum: Valor do Pedido: R$ " + ValorTotalPedido().ToString("F2") ;
            }
            else
            {
                return "Ciente Vip: Valor do Pedido: R$ " + ValorTotalPedido().ToString("F2");
            }
        }
    }
}
