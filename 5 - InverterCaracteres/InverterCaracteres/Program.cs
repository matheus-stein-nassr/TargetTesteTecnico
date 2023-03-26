namespace InverterCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string texto = "matheus";

            char[] caracteres = texto.ToCharArray();

            int i = 0;
            int j = caracteres.Length - 1;
            while (i < j)
            {
                char temp = caracteres[i];
                caracteres[i] = caracteres[j];
                caracteres[j] = temp;
                i++;
                j--;
            }

            string textoInvertido = new string(caracteres);

            Console.WriteLine($"String a ser invertida: {texto}\n");
            Console.WriteLine($"Resultado: {textoInvertido}");
        }
    }
}