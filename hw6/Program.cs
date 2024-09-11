namespace hw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> plus = (a, b) => a + b;
            Func<double, double, double> minus = (a, b) => a - b;
            Func<double, double, double> multiply = (a, b) => a * b;
            Func<double, double, double> divide = (a, b) => b != 0 ? a / b : a;
            Func<double, double, double> Remain = (a, b) => a % b;
            Func<double, double, double> Pow = (a, b) => Math.Pow(a,b);

            double result;

            Console.Write("Input first number: ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("Input second number: ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Input sign(+, -, *, /, ^, %):");
            string sign = Console.ReadLine();

            if (sign == "+")
            {
                result = plus(a, b);
            }
            else if (sign == "-")
            {
                result = minus(a, b);
            }
            else if (sign == "*")
            {
                result = multiply(a, b);
            }
            else if (sign == "/")
            {
                result = divide(a, b);
            }
            else if (sign == "^")
            {
                result = Pow(a, b);
            }
            else if (sign == "%")
            {
                result = Remain(a, b);
            }
            else
            {
                Console.WriteLine("Wrong sign");
                return;
            };
            Console.WriteLine($"Result: {result}");
        }
    }
}
