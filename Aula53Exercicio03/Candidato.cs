using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string Partido { get; set; }
        public int QuantidadeDeVotos { get; set; }
        public int Numero { get; set; }

        public Candidato(string nome, string partido, int numero)
        {
            Nome = nome;
            Partido = partido;
            Numero = numero;
            QuantidadeDeVotos = 0;
        }

        public override string ToString()
        {
            return Nome + " " + Partido + " Número: " + Numero;
        }

        public string Resultado()
        {
            return " Candidato: " + Nome + " Teve " + QuantidadeDeVotos + " Votos";
        }
    }

    public class CandidatoRepository
    {
        public static List<Candidato> InicializarCandidatos()
        {
            List<Candidato> candidatos = new List<Candidato>();
            candidatos.Add(new Candidato("Zezinho da Privada", "PTE", 23));
            candidatos.Add(new Candidato("João do Pé de Serra", "PJTR", 66));
            candidatos.Add(new Candidato("Menino da Ti", "PLTI", 99));

            return candidatos;
        }
        
    }
}
