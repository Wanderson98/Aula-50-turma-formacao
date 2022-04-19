using System;

namespace Aula50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Funções de Texto -------------");
            string empresa = " Cast Group - Soluções em Ti End-to-End ";
            Console.WriteLine($"Texto com espaço: {empresa}");
            Console.WriteLine("Trim - retira espaços em Branco antes e após a expressão! ");
            Console.WriteLine($"Total de caracteres da Variavel com espaços: {empresa.Length}");
            Console.WriteLine($"Texto sem espaço: {empresa.Trim()}");
            Console.WriteLine($"Total de caracteres da Variavel sem espaços: {empresa.Trim().Length}");
            empresa = empresa.Trim();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("To Upper e To Lower - Maiusculas e minusculas respec");
            string nome = "Wanderson";
            Console.WriteLine("To Upper Maiusculas: " + nome.ToUpper());
            Console.WriteLine("To Upper Minusculas: " + nome.ToLower());
            Console.WriteLine("------------------------------------------------------");
            string nomeUpper = "WANDERSON ANDRADE";
            string nomeLower = "wanderson andrade";

            //comparação 1
            if(nomeUpper == nomeLower)
            {
                Console.WriteLine("1 - Nomes iguais");
            }
            else
            {
                Console.WriteLine("1 - Nomes Diferentes");
            }
            //comparação 2
            if (nomeUpper == nomeLower.ToUpper())
            {
                Console.WriteLine("2 - Nomes iguais");
            }
            else
            {
                Console.WriteLine("2 - Nomes Diferentes");
            }
            //comparação 3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("3 - Nomes iguais");
            }
            else
            {
                Console.WriteLine("3 - Nomes Diferentes");
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-------- Remove caracteres a partir da esquerda-------");
            Console.WriteLine("Texto: " + empresa);
            Console.WriteLine("Texto a esquerda:" + empresa.Remove(10));
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Pegar primeiro nome ");
            string[] nomes = { "Wanderson Andrade", "Nara Matos", "José Rico", "Ednaldo Pereira" };
            foreach (var n in nomes)
            {
                Console.WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("--------  Replace troca o valor -------");
            string empresa2 = "Microsoft Corporation";
            //quando não se sabe o tipo a ser passado usa o Var
            var novaEmpresa = empresa2.Replace("Microsoft", "Google");
            Console.WriteLine(novaEmpresa);
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("Split quebra a string");
            string livro = "Avançado em C# - Cast Group";
            Console.WriteLine(livro);
            string[] blocos = livro.Split(' ');
            int i = 1;
            foreach (var b in blocos)
            {
                Console.WriteLine($"Texto {i++}: {b}");
            }
            Console.WriteLine("Total palavras no titulo: " + blocos.Length );
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("Substring");
            string nivelAprendizado = "Este livro é básico em C#";
            Console.WriteLine(nivelAprendizado);
            Console.WriteLine("Extrair parte da string");
            Console.WriteLine(nivelAprendizado.Substring(5,14));

            string[] cesta = { "5 Laranjas", "10 Goiabas Vermelhas", "5 Pêssegos Doces", "4 Bananas" };
            int soma = 0;
            foreach (var item in cesta)
            {
                Console.WriteLine(item.Substring(item.IndexOf(" ")+1));
                 soma += int.Parse(item.Substring(0, item.IndexOf(" ")));
                
            }
            Console.WriteLine(soma);
        }
    }
}
