namespace TesteEmprego.Questoes
{
    public class Questao1
    {

        public static void CalcularSoma()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while(K < INDICE){
                K = K + 1; 
                SOMA = SOMA + K;
                Console.WriteLine(SOMA);
            }

            Console.WriteLine($"VALOR FINAL DA SOMA = {SOMA}");
        }
    }
}