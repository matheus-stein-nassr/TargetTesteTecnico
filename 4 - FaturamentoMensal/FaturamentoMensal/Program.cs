namespace FaturamentoMensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalMensal = 0;
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            totalMensal = sp + rj + mg + es + outros;

            double percentualSP = (sp / totalMensal) * 100;
            double percentualRJ = (rj / totalMensal) * 100;
            double percentualMG = (mg / totalMensal) * 100;
            double percentualES = (es / totalMensal) * 100;
            double percentualOutros = (outros / totalMensal) * 100;

            Console.WriteLine("Percentual de representaçao de cada estado: \n");
            Console.WriteLine($"Percentual de SP: {percentualSP.ToString("F2")}%");
            Console.WriteLine($"Percentual de RJ: {percentualRJ.ToString("F2")}%");
            Console.WriteLine($"Percentual de MG: {percentualMG.ToString("F2")}%");
            Console.WriteLine($"Percentual de ES: {percentualES.ToString("F2")}%");
            Console.WriteLine($"Percentual de Outros estados: {percentualOutros.ToString("F2")}%");
        }
    }
}