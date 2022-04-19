using System;

namespace Aula53Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Votação
            // ter cadastrado em Lista os Votantes
            // Vai existir uma Classe candidatos pelo menos 3 candidatos 
            // Vai ter Voto 
            // Cada um do dos votantes só pode votar uma vez
            // Começa com voltou - não 
            // Fornecer titulo de eleitor ( pesquisar se existe titulo no array e se ainda não votou) se tudo tiver ok libera 
            // O voto deve ter apenas um candidato e no final (vai ser o último eleitor votar) 
            //o sistema deve informar o percentual e o total de votos, deve se permitir voto nulo e em branco 

            Votacao votacao = new Votacao();
            votacao.IninicializarVotacao();

           
           
        }
    }
}
