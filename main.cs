using System;

class Program{
    static void Main(string[] args){
        int number;

        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number < 0)
            {
                Console.WriteLine($"Invalid value: {input}");
                Console.WriteLine();
                continue;
            }
            else if (number == 0)
            {
                Console.WriteLine("Closing program...");
                return;
            }

            TreeStar(number);
            Console.WriteLine();

        } while (true);
    }

    static void TreeStar(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
