// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("Opção 1: Soma" );
            Console.WriteLine("Opção 2: Subtracao" );
            Console.WriteLine("Opção 3: Multiplicacao" );
            Console.WriteLine("Opção 4: Divisao");
            Console.WriteLine("Opção 5: Sair");
            Console.WriteLine("=======================");
            Console.WriteLine("Selecione uma opção");
            
            int operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Multiplicacao();
                    break;
                case 4: Divisao();
                    break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida, por favor insira uma opção válida dentre as opções listadas :)");
                break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Entre com o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = value1 + value2;
            
            Console.WriteLine($"A soma dos resultados é {resultado}");
            Console.ReadKey();

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Entre com o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 - value2;
            Console.WriteLine("");
            
            Console.WriteLine($"O valor da subtração foi de {result}");
            Console.ReadKey();
        }
        
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Entre com o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 * value2;
            Console.WriteLine("");
            
            Console.WriteLine($"O valor da multiplicacao foi de {result}");
            Console.ReadKey();
        }
        
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Entre com o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 / value2;
            Console.WriteLine("");
            
            Console.WriteLine($"O valor da divisao foi de {result}");
            Console.ReadKey();
        }
    }
}
