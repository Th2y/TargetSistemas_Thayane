using System.Text.Json;

namespace TesteEmprego.Questoes
{
    public class FaturamentoDia
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    public class Questao3
    {
        public static void AnalisarFaturamento()
        {
            string jsonPath = Path.Combine("data", "dados.json");;

            if (!File.Exists(jsonPath))
            {
                Console.WriteLine($"Arquivo '{jsonPath}' não encontrado.");
                return;
            }

            string jsonContent = File.ReadAllText(jsonPath);
            List<FaturamentoDia>? dados = JsonSerializer.Deserialize<List<FaturamentoDia>>(jsonContent);

            if (dados == null || dados.Count == 0)
            {
                Console.WriteLine("Erro ao ler o JSON ou JSON vazio.");
                return;
            }

            dados.RemoveAll(fatur => fatur.valor <= 0);

            /* Outra forma de fazer seria:
            List<FaturamentoDia> dadosNaoZerados = [];
            foreach (FaturamentoDia fatur in dados)
            {
                if(fatur.valor > 0)
                {
                    dadosNaoZerados.Add(fatur);
                }
            }
            dados = dadosNaoZerados;*/

            if (dados.Count == 0)
            {
                Console.WriteLine("Não há dias com faturamento registrado.");
                return;
            }

            double menor = dados.Min(d => d.valor);
            double maior = dados.Max(d => d.valor);
            double media = dados.Average(d => d.valor);
            int diasAcimaDaMedia = dados.Count(d => d.valor > media);

            Console.WriteLine($"Menor faturamento: R$ {menor:F2}");
            Console.WriteLine($"Maior faturamento: R$ {maior:F2}");
            Console.WriteLine($"Dias com faturamento acima da média mensal (R$ {media:F2}): {diasAcimaDaMedia}");
        }
    }
}