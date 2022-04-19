using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    public class Eleitor
    {
        public string  Nome { get; set; }
        public int Titulo { get; set; }
        public bool Votou { get; set; }

        public Eleitor(string nome, int titulo)
        {
            Nome = nome;
            Titulo = titulo;
            Votou = false;
        }

        public override string ToString()
        {
            return Nome + " " + Titulo;
        }

    }

    public class EleitoresRepository
    {
        public static List<Eleitor> InicializarEleitores()
        {
            List<Eleitor> eleitores = new List<Eleitor>();
            eleitores.Add(new Eleitor("Joao Vitor", 01));
            eleitores.Add(new Eleitor("Ednado Pereira", 02));
            eleitores.Add(new Eleitor("Luana Alves", 03));
            //eleitores.Add(new Eleitor("Mariana Rios", 04));
            //eleitores.Add(new Eleitor("Cleber Vinicius", 05));
            //eleitores.Add(new Eleitor("Lucas Andrade", 06));
            //eleitores.Add(new Eleitor("Richard Freitas", 07));
            //eleitores.Add(new Eleitor("Maria Teles", 08));
            //eleitores.Add(new Eleitor("José Ricardo", 09));
            //eleitores.Add(new Eleitor("Larissa Montenegro", 10));

            return eleitores;
        }

    }
}
