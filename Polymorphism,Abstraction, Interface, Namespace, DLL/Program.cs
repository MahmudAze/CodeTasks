namespace Polymorphism_Abstraction__Interface__Namespace__DLL
{
    interface ICalculation
    {
        double Calculate(double a, double b, char operation);
    }

    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, char operation)
        {
            switch(operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Sifira bolmek olmaz!");
                        return 0;
                    }
                    return a / b;
                default:
                    Console.WriteLine("Yanlis emeliyyat daxil etdiniz!");
                    return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Kalkulyator ---");

            Console.Write("Birinci ededi daxil edin: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Emeliyyati daxil edin (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            double b = Convert.ToInt32(Console.ReadLine());

            ICalculation calculation = new Calculation();

            double result = calculation.Calculate(a, b, op);

            Console.WriteLine("Netice: " + result);
        }
    }
}
