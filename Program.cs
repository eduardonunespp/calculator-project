// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entre com o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = value1 + value2;
            
            Console.WriteLine($"A soma dos resultados é {resultado}");



        }
    }
}
