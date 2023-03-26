namespace FaturamentoDiario
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = File.ReadAllText(@"C:\Users\Matheus\Desktop\CSharp\FaturamentoDiario\FaturamentoDiario\Faturamento.json");

            FaturamentoDiario faturamento = JsonConvert.DeserializeObject<FaturamentoDiario>(jsonString);

            double[] faturamentoDiario = faturamento.Valores;

            double minimo = faturamentoDiario[0];
            double maximo = faturamentoDiario[0];
            double soma = 0;

            int diasComFaturamento = 0;
            double mediaMensal = 0;
            foreach (double valor in faturamentoDiario)
            {
                if (valor > 0)
                {
                    soma += valor;
                    diasComFaturamento++;
                }
            }
            mediaMensal = soma / diasComFaturamento;

            foreach (double valor in faturamentoDiario)
            {
                if (valor < minimo)
                {
                    minimo = valor;
                }
                if (valor > maximo)
                {
                    maximo = valor;
                }
            }

            int diasAcimaDaMedia = 0;
            foreach (double valor in faturamentoDiario)
            {
                if (valor > mediaMensal)
                {
                    diasAcimaDaMedia++;
                }
            }

            Console.WriteLine("Menor valor de faturamento: " + minimo);
            Console.WriteLine("Maior valor de faturamento: " + maximo);
            Console.WriteLine("Número de dias com faturamento acima da média: " + diasAcimaDaMedia);
        }
    }

}