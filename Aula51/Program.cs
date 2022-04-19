using System;
using System.Globalization;

namespace Aula51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime festa = new DateTime(2022, 04, 24);
            //Console.WriteLine(festa);
            // Console.WriteLine(festa.ToString("dd/MM/yyyy"));

            int dia = 19;
            int mes = 04;
            int ano = 2022;

            DateTime dataDeAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2022, 10, 22);

            Console.WriteLine("------------Funções de data -----------------");
            Console.WriteLine($"Aniversario {dataDeAniversario}");
            Console.WriteLine($"Aniversario {dataDeAniversario:dd/MM/yyyy}");
            Console.WriteLine($"Aniversario {dataDeAniversario:ddd dd/MM/yyyy}");
            Console.WriteLine($"Aniversario {dataDeAniversario:dddd dd/MM/yyyy}");
            Console.WriteLine($"Aniversario {dataDeAniversario:dddd MMMM dd/MM/yyyy}");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Funções de Data Today");
            DateTime hoje = DateTime.Today;
            DateTime hora = DateTime.Now;
            Console.WriteLine($"Today{hoje: dd/MM/yyyy}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Funções de Data Day, month year");
            DateTime dataHora = DateTime.Now;
            Console.WriteLine("Data de agora " + dataHora);
            Console.WriteLine("Dia: " + dataHora.Day);
            Console.WriteLine("Month: " + dataHora.Month);
            Console.WriteLine("Year: " + dataHora.Year);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Funções de Data Manipulação");
            DateTime dtPedido = DateTime.Today;
            //adicionar 35 dias
            DateTime dtVencimento = dtPedido.AddDays(35);
      
            //adicionar 2 meses a data de pedido, primeiro pagamento
            DateTime dtPgto = dtVencimento.AddMonths(2);
            Console.WriteLine($"Pedido feito em: {dtPedido:dd/MM/yyy}");
            Console.WriteLine($"Vence em (formatação completa): {dtVencimento.ToLongDateString()}");
            Console.WriteLine($"Vence em (formatação curta): {dtVencimento.ToShortDateString()}");
            Console.WriteLine($"Primeiro Pagamento em: {dtPgto:dd/MM/yyy}");
            //dia da semana
            Console.WriteLine($"Dia da semana do vencimento(Inglês): {dtVencimento.DayOfWeek}" );
            Console.WriteLine($"Dia da semana do vencimento(Pt-BR): {dtVencimento.ToString("dddd", new CultureInfo("pt-BR"))}" );
            Console.WriteLine($"Número do dia da semana: {(int) dtVencimento.DayOfWeek}");

            //dia do ano
            var qtdDays = dtPgto.Subtract(dtPedido);
            Console.WriteLine("Diferença entre a data de pagamento e do pedido: " + qtdDays);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Conversão data");
            string dataTexto = "19/04/2022";
            DateTime dataTextoConverte;
            //trypArse para converter de string para datetime
            if(DateTime.TryParse(dataTexto, out dataTextoConverte))
            {
                Console.WriteLine("data convertida com sucesso");
            }
            else
            {
                Console.WriteLine("erro na conversao");
            }
        }
    }
}
