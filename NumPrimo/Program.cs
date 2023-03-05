internal class Program
{
    private static void Main(string[] args)
    {
        double n, count = 0;

        Console.WriteLine("Digite um numero positivo qualquer:");
        n = double.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i ++)
        {
            if (n % i == 0)
            {
                count += 1;
            }
        }
        if(count == 2)
        {
            Console.WriteLine("O numero é primo");
        }
        else
        {
            Console.WriteLine("O numero não é primo");
        }
    }
}