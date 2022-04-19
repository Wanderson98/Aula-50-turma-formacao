using System;
using System.Collections.Generic;
using System.Threading;


namespace Aula53Exercicio03
{
    internal class Votacao
    {
        public double VotosTotais { get; set; }
        public double VotosNullos { get; set; }
        public double VotosEmBranco { get; set; }

        public Votacao()
        {
            VotosTotais = 0;
            VotosNullos = 0;
            VotosEmBranco = 0;
        }

        public void IninicializarVotacao()
        {
            List<Candidato> candidatos = CandidatoRepository.InicializarCandidatos();
            List<Eleitor> eleitores = EleitoresRepository.InicializarEleitores();
  

            while (VotosTotais < eleitores.Count)
            {
                MostrarCandidatos(candidatos);

                Console.WriteLine("\n Números de Votos até agora: " + VotosTotais);
                Console.Write("\n Digite seu titulo: ");
                int titulo = int.Parse(Console.ReadLine());
                Eleitor eleitorVoto = EncontrarEleitor(eleitores, titulo);
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
                            Console.Write("\n Digite o número do candidato: ");
                            int numCand = int.Parse(Console.ReadLine());
                            if (EncontrarCandidato(candidatos, numCand) == null)
                            {
                                Console.WriteLine("\n Candidato Não Encontrado!!");
                            }
                            else
                            {
                                Candidato candVoto = EncontrarCandidato(candidatos, numCand);
                                Console.WriteLine(" Candidato Selecionado " + candVoto);
                                Console.Write("\n Confirmar Voto? S/N: ");
                                char confirVoto = char.Parse(Console.ReadLine().ToLower());
                                if (confirVoto == 's')
                                {
                                    ConfirmarVoto(eleitorVoto, candVoto);

                                }
                                else
                                {
                                    Console.WriteLine("\n Voto não Computado! ");
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
                Thread.Sleep(2000);
                Console.Clear();
            }
            ResultadoEleicao(candidatos);
        }

        public void MostrarCandidatos(List<Candidato> candidatos)
        {
            Console.WriteLine("-------- Candidatos --------------");
            foreach (Candidato cand in candidatos)
            {
                Console.WriteLine(" " + cand);
            }
            Console.WriteLine("----------------------------------");
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
            Console.WriteLine("\n Você votou em: " + cand);
        }

        public void VotoBrancoNulo(Eleitor eleitor)
        {
            Console.Write("\n Digite B para votar em Branco ou N para votar em Nulo: ");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 'b')
            {
                VotosEmBranco++;
                VotosTotais++;
                Console.WriteLine("\n Você Votou em Branco!");
                eleitor.Votou = true;
            }
            else if (resposta == 'n')
            {
                VotosNullos++;
                VotosTotais++;
                Console.WriteLine(" Você Votou em Nulo!");
                eleitor.Votou = true;
            }
            else
            {
                Console.WriteLine("\n Voto não Computado! ");
            }
        }
        
        public void ResultadoEleicao(List<Candidato> candidatos)
        {
            foreach (Candidato cad in candidatos)
            {
                Console.WriteLine(" Quantidade de Cotos Candidado - {0}: {1} - {2}% dos Votos", cad.Nome, cad.QuantidadeDeVotos, (cad.QuantidadeDeVotos / VotosTotais * 100));
            }
            Console.WriteLine(" Quantidade de Votos em Branco: {0}  - {1}% dos Votos", VotosEmBranco, (VotosEmBranco / VotosTotais * 100));
            Console.WriteLine(" Quantidade de Votos Nulos: {0}  - {1}% dos Votos",  VotosNullos,(VotosNullos/VotosTotais*100));

        }
    }


}
