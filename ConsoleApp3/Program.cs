using ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string op = Console.ReadLine();
        switch (op)
        {
            case"+":
                Class1<int> C1 = new Class1<int>();
                C1.num1 = int.Parse(num1);
                C1.num2 = int.Parse(num2);
                Console.WriteLine(C1.num1 + C1.num2);
                break;
            case "-":
                Class1<int> C2 = new Class1<int>();
                C2.num1 = int.Parse(num1);
                C2.num2 = int.Parse(num2);
                Console.WriteLine(C2.num1 - C2.num2);
                break;
            case "*":
                Class1<int> C3 = new Class1<int>();
                C3.num1 = int.Parse(num1);
                C3.num2 = int.Parse(num2);
                Console.WriteLine(C3.num1 * C3.num2);
                break;
            case "/":
                Class1<double> C4 = new Class1<double>();
                C4.num1 = double.Parse(num1);
                C4.num2 = double.Parse(num2);
                Console.WriteLine(C4.num1 / C4.num2);
                break;
        }
    }
}