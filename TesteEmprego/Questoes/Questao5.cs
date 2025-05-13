namespace TesteEmprego.Questoes
{
    public class Questao5
    {
        public static void InverterString()
        {
            string? textoOriginal = null;

            while(textoOriginal == null || textoOriginal.Length == 0)
            {
                Console.WriteLine("Digite uma palavra: ");
                textoOriginal = Console.ReadLine();

                if (textoOriginal == null || textoOriginal.Length == 0)
                {
                    Console.WriteLine("Palavra inválida! Tente novamente.");
                    continue;
                }
            }

            Console.WriteLine($"Texto original: {textoOriginal}");

            if(textoOriginal.Length == 1)
            {
                Console.WriteLine($"Texto invertido: {textoOriginal}");
                return;
            }

            string textoInvertido = "";
            for (int i = textoOriginal.Length - 1; i >= 0; i--)
            {
                textoInvertido += textoOriginal[i];
            }

            Console.WriteLine($"Texto invertido: {textoInvertido}");
        }
    }
}