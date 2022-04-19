using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    internal class Votacao
    {
        public int VotosTotais { get; set; }
        public int VotosNullos { get; set; }
        public int VotosEmBranco { get; set; }

        public Votacao()
        {
            VotosTotais = 0;
            VotosNullos = 0;
            VotosEmBranco = 0;
        }

        public void IninicializarVotacao()
        {
            List<Candidato> candi = CandidatoRepository.InicializarCandidatos();
            List<Eleitor> eleit = EleitoresRepository.InicializarEleitores();
            Console.WriteLine("-------- Candidatos --------------");
            foreach (Candidato cand in candi)
            {
                Console.WriteLine(" " + cand);
            }
            Console.WriteLine("----------------------------------");


            while (VotosTotais < eleit.Count)
            {
                Console.WriteLine("\n Números de Votos até agora: " + VotosTotais);
                Console.Write("\n Digite seu titulo: ");
                int titulo = int.Parse(Console.ReadLine());
                Eleitor eleitorVoto = EncontrarEleitor(eleit, titulo);
                if (eleitorVoto != null)
                {
                    if (!eleitorVoto.Votou)
                    {

                        Console.WriteLine(" Eleitor: " + eleitorVoto);

                        Console.Write("\n Deseja Votar em Branco ou Nulo ? (s/n) ");
                        char respostaBN = char.Parse(Console.ReadLine().ToLower());
                        if (respostaBN == 's')
                        {
                            VotoBrancoNulo(eleitorVoto);
                        }
                        else
                        {
                            Console.Write(" Digite o número do candidato: ");
                            int numCand = int.Parse(Console.ReadLine());
                            if (EncontrarCandidato(candi, numCand) == null)
                            {
                                Console.WriteLine(" Candidato Não Encontrado");
                            }
                            else
                            {
                                Candidato candVoto = EncontrarCandidato(candi, numCand);
                                Console.WriteLine(" Candidato Selecionado " + candVoto);
                                Console.Write(" Confirmar Voto? S/N: ");
                                char confirVoto = char.Parse(Console.ReadLine().ToLower());
                                if (confirVoto == 's')
                                {
                                    ConfirmarVoto(eleitorVoto, candVoto);

                                }
                                else
                                {
                                    Console.WriteLine(" Voto não Computado! ");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Eleitor Escolhido Já Votou !!");
                    }
                }
                else
                {
                    Console.WriteLine(" Eleitor Não Encontrado !");
                }
            }

            foreach(Candidato ca in candi)
            {
                Console.WriteLine(ca.Resultado());
            }
            Console.WriteLine(" Quantidade de Votos em Branco: " + VotosEmBranco);
            Console.WriteLine(" Quantidade de Votos Nullos: " + VotosNullos);


        }

        public Eleitor EncontrarEleitor(List<Eleitor> eleitores, int titulo)
        {
            return eleitores.Find(x => x.Titulo == titulo);
        }

        public Candidato EncontrarCandidato(List<Candidato> candidatos, int numero)
        {
            return candidatos.Find(x => x.Numero == numero);
        }

        public void ConfirmarVoto(Eleitor eleitor, Candidato cand)
        {
            eleitor.Votou = true;
            VotosTotais++;
            cand.QuantidadeDeVotos++;
            Console.WriteLine("Você votou em: " + cand);
        }

        public void VotoBrancoNulo(Eleitor eleitor)
        {
            Console.Write(" Digite B para votar em Branco ou N para votar em Nulo: ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 'b')
            {
                VotosEmBranco++;
                VotosTotais++;
                Console.WriteLine(" Você Votou em Branco");
                eleitor.Votou = true;
            }
            else if (resposta == 'n')
            {
                VotosNullos++;
                VotosTotais++;
                Console.WriteLine(" Você Votou em Nulo");
                eleitor.Votou = true;
            }
        }
    }


}
