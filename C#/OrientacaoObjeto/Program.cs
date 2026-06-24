namespace OrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa(
            "Vitor", 
            new DateTime(1998, 6, 19), 
            1.83, 
            "03893211098", 
            true);
            

            string nome1 = "Vitor";
            int idade1 = 27;
            double altura1 = 1.83;

            Console.WriteLine("Informações da Pessoa 1");
            Console.WriteLine($"Nome {pessoa1.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa1.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa1.Altura}");
            Console.WriteLine($"Cpf {pessoa1.Cpf}");
            Console.WriteLine($"Está ativo {pessoa1.IsAtivo}");

            Console.WriteLine($"Novo nome pessoa 1 {pessoa1.Nome}");

            Pessoa pessoa2 = new Pessoa(
                "Douglas",
                new DateTime(1996, 11, 20),
                1.77,
                "10382102755",
                true);
        
            Console.WriteLine("Informações da Pessoa 2");
            Console.WriteLine($"Nome {pessoa2.Nome}");
            Console.WriteLine($"Data de Nascimento {pessoa2.DataDeNascimento}");
            Console.WriteLine($"Altura {pessoa2.Altura}");
            Console.WriteLine($"Cpf {pessoa2.Cpf}");
            Console.WriteLine($"Está ativo {pessoa2.IsAtivo}");


            Cachorro junior = new Cachorro(
              "junior",
              new DateTime(2026,01, 02),
              0.2,
              false,
              "Pinscher");
            

            Console.WriteLine("Informações do cachorro Junior");
            Console.WriteLine($"Nome {junior.Nome}");
            Console.WriteLine($"Data de nascimento {junior.DataDeNascimento}");
            Console.WriteLine($"Raca {junior.Raca}");
            junior.SeComunicar();


            Pedido pedido = new Pedido(pessoa1,DateTime.Now);
            pedido.ValorTotal = 100.99;
            pedido.Observacao = "Cliente vai buscar cachorro às 15:00h";

            Console.WriteLine("Informações do pedido");
            Console.WriteLine($"Cliente {pedido.Cliente.Nome}");
            Console.WriteLine($"Observação do pedido {pedido.Observacao}");

            Console.WriteLine("Criação do pedido 2");
            var pedido2 = new Pedido(pessoa2, DateTime.Now, 199.90, "Sem observação");

            Console.WriteLine("Informações do pedido 2");
            Console.WriteLine($"Cliente {pedido2.Cliente.Nome}");
            Console.WriteLine($"Observação do pedido {pedido2.Observacao}");


        }
    }
}
