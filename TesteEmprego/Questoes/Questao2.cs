namespace TesteEmprego.Questoes
{
    public class Questao2
    {
        public static void VerificarFibonacci()
        {
            int numero = 0;
            bool valido = false;

            while(!valido)
            {
                Console.Write("Digite um número inteiro: ");
                string? entrada = Console.ReadLine();
                if (entrada == null)
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }

                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Entrada inválida pois não é um número inteiro. Tente novamente.");
                    return;
                }

                valido = true;
            }

            if (numero == 0 || numero == 1)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
                return;
            }

            int a = 0;
            int b = 1;

            while (b < numero)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            if (b == numero)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
            }
        }
    }
}