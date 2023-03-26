namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            bool encontrado = false;
            int a = 0, b = 1, c = 0;

            Console.Write($"\nSequência de Fibonacci: {num}\n");

            while (c < num)
            {
                c = a + b;
                Console.Write(" " + c);

                if (c == num)
                {
                    encontrado = true;
                }

                a = b;
                b = c;
            }

            Console.WriteLine();

            if (encontrado)
            {
                Console.WriteLine(num + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine(num + " não pertence à sequência de Fibonacci.");
            }
        }
    }
}