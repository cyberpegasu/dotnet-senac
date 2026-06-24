namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}");

                double numero = i;
                double raiz = Math.Sqrt(numero);

                Console.WriteLine($"A raiz quadrada de {numero} é {raiz:F2}");

            }
        }
    }
}
