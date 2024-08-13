using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // Configura para usar ponto como separador decimal, se necessário
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Solicita ao usuário para inserir os valores
        // Console.WriteLine("Digite o valor do Principal (valor inicial a ser aplicado):");
        double P = Convert.ToDouble(Console.ReadLine(), culture); // Lê o valor principal P

        // Console.WriteLine("Digite a taxa de juros anual (exemplo: 0.05 para 5%):");
        double i = Convert.ToDouble(Console.ReadLine(), culture); // Lê a taxa de juros i

        // Console.WriteLine("Digite quantos anos o valor ficará investido:");
        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de períodos n

        // Exibe valores para depuração
        // Console.WriteLine($"Valor Principal (P): {P}");
        // Console.WriteLine($"Taxa de Juros Anual (i): {i}");
        // Console.WriteLine($"Número de Anos (n): {n}");

        // Calcula o montante final utilizando a função CalcularJurosSimples
        double montanteFinal = CalcularJurosSimples(P, i, n);

        // Exibe o resultado
        // Console.WriteLine($"O valor ao final do prazo será de: R$ {montanteFinal}");
        Console.WriteLine(montanteFinal); // Mostra o montante final calculado
    }

    public static double CalcularJurosSimples(double P, double i, int n)
    {
        // Calcula o montante final com juros simples
        double juros = P * i * n;
        double montanteFinal = P + juros;

        // Exibe valores para depuração
        // Console.WriteLine($"Juros Calculado: {juros}");
        // Console.WriteLine($"Montante Final Calculado: {montanteFinal}");

        return montanteFinal;
    }
}
