namespace Aula02Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            // o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.
            // Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

            // Declaração das variáveis para armazenar os dados do vendedor
            int numeroVendedor;
            double salarioFixo, totalVendas, percentualComissao, salarioTotal;

            // Leitura do número do vendedor a partir do teclado
            Console.WriteLine("Digite o número do vendedor: ");
            numeroVendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            // Leitura do salário fixo do vendedor a partir do teclado
            Console.WriteLine("Digite o salário fixo do vendedor: ");
            salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            // Leitura do total de vendas do vendedor a partir do teclado
            Console.WriteLine("Digite o total de vendas do vendedor: ");
            totalVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            // Leitura do percentual de comissão do vendedor a partir do teclado
            Console.WriteLine("Digite o percentual de comissão do vendedor (em %): ");
            percentualComissao = double.Parse(Console.ReadLine()) / 100.0;
            Console.WriteLine("------------------------------------------");

            // Cálculo do salário total do vendedor
            salarioTotal = salarioFixo + totalVendas * percentualComissao;

            // Exibição do número do vendedor e do salário total formatado como moeda
            Console.WriteLine("O salário total do vendedor {0} é: {1:C}", numeroVendedor, salarioTotal);
            Console.WriteLine("------------------------------------------");
        }
    }
}