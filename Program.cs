using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Conversor de Temperatura ===");
            Console.WriteLine("Escolha a conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            if (opcao != "1" && opcao != "2")
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            Console.Write("Digite a temperatura: ");
            if (!double.TryParse(Console.ReadLine(), out double temperatura))
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            double resultado = opcao == "1"
                ? Conversor.CelsiusParaFahrenheit(temperatura)
                : Conversor.FahrenheitParaCelsius(temperatura);

            string unidadeOrigem = opcao == "1" ? "Celsius" : "Fahrenheit";
            string unidadeDestino = opcao == "1" ? "Fahrenheit" : "Celsius";

            Console.WriteLine($"\n{temperatura}° {unidadeOrigem} = {resultado:F2}° {unidadeDestino}");
        }
    }
}
