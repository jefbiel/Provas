using System;

/// <summary>
/// Programa para calcular a área de diferentes formas geométricas (círculo, triângulo e retângulo),
/// utilizando sobrecarga de métodos.
/// </summary>
class Program
{
    /// <summary>
    /// Imprime o valor numérico da área calculada.
    /// </summary>
    /// <param name="valor">Área a ser exibida.</param>
    static void Print(double valor)
    {
        Console.WriteLine($"Área calculada: {valor}");
    }

    /// <summary>
    /// Imprime uma mensagem de texto no console.
    /// </summary>
    /// <param name="mensagem">Mensagem a ser exibida.</param>
    static void Print(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    /// <summary>
    /// Calcula a área de um círculo.
    /// </summary>
    /// <param name="raio">Raio do círculo.</param>
    /// <returns>Área do círculo.</returns>
    static double CalcularArea(double raio)
    {
        return Math.PI * raio * raio;
    }

    /// <summary>
    /// Calcula a área de um triângulo.
    /// </summary>
    /// <param name="b">Base do triângulo.</param>
    /// <param name="altura">Altura do triângulo.</param>
    /// <returns>Área do triângulo.</returns>
    static double CalcularArea(double b, double altura)
    {
        return (b * altura) / 2;
    }

    /// <summary>
    /// Calcula a área de um retângulo.
    /// </summary>
    /// <param name="comprimento">Comprimento do retângulo.</param>
    /// <param name="largura">Largura do retângulo.</param>
    /// <param name="isRetangulo">Parâmetro auxiliar para diferenciar a sobrecarga (sempre true).</param>
    /// <returns>Área do retângulo.</returns>
    static double CalcularArea(double comprimento, double largura, bool isRetangulo)
    {
        return comprimento * largura;
    }

    /// <summary>
    /// Ponto de entrada principal do programa.
    /// Permite ao usuário escolher uma forma geométrica e calcular sua área.
    /// </summary>
    static void Main()
    {
        // Entrada do nome do usuário
        Print("Digite seu nome:");
        string nome = Console.ReadLine();

        // Exibe menu de opções
        Print($"Olá, {nome}! Escolha a forma para calcular a área:");
        Print("1 - Círculo");
        Print("2 - Triângulo");
        Print("3 - Retângulo");
        Print("Digite o número correspondente à sua escolha:");

        string escolha = Console.ReadLine();
        double area = 0;

        // Escolha do usuário
        if (escolha == "1")
        {
            Print("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine());
            area = CalcularArea(raio);
            Print(area);
        }
        else if (escolha == "2")
        {
            Print("Digite a base do triângulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Print("Digite a altura do triângulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            area = CalcularArea(baseTriangulo, alturaTriangulo);
            Print(area);
        }
        else if (escolha == "3")
        {
            Print("Digite o comprimento do retângulo:");
            double comprimento = double.Parse(Console.ReadLine());
            Print("Digite a largura do retângulo:");
            double largura = double.Parse(Console.ReadLine());
            area = CalcularArea(comprimento, largura, true);
            Print(area);
        }
        else
        {
            Print("Excelente escolha… porém eu não lhe dei essa opção. Portanto, reinicie o código.");
        }
    }
}
