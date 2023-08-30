internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quantos numeros vc vai somar?");
        int N = int.Parse(Console.ReadLine());

        int soma = 0; //nao esquecer de começar a variavel antes do for/while/if
        for (int i = 1; i <= N; i++) // peimeiro executa uma vez, segundo acontece enquanto for verdadeiro, ultimo incrementa toda vez que repetir
        {
            Console.WriteLine("Valor #{0}:", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }

        Console.WriteLine("soma = " + soma);
    }
}