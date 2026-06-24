using System.Reflection.Metadata.Ecma335;

namespace meuPrimeiroProjetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Meu nome é Vitor");

            int idade = 27;
            string nome = "Vitor";
            string sobrenome = "Martins";
            bool ehAluno = true;
            double altura = 1.83;

            //  Console.WriteLine($"Meu nome é {nome} {sobrenome}.");
            // Console.WriteLine($"Tenho {idade} anos de idade.");
            //  Console.WriteLine($"Sou aluno: {ehAluno}");
            //  Console.WriteLine($"Tenho {altura} de altura");

            string nomeCompleto = obterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"Meu nome é {nomeCompleto}");
        }


        static string obterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }
    
    static void ExibirSeEhAlunoEAltura(bool ehAluno, double altura)
        {
            Console.WriteLine($"Sou aluno: {ehAluno}");
            Console.WriteLine($"Tenho {altura} de altura");
        }
    }
}
