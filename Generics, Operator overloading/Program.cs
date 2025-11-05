namespace Generics__Operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair1 = new Pair<int, string>(1, "One");
            pair1.Display();

            Pair<string, string> pair2 = new Pair<string, string>("Hello", "World");
            pair2.Display();

            SimpleGenericType<int> intExample = new(52);
            intExample.Print(intExample.RandomValue);

            SimpleGenericType<string> stringExample = new("Hello, Generics");
            stringExample.Print(stringExample.RandomValue);

            SimpleGenericType<double> doubleExample = new(3.14);
            doubleExample.Print(doubleExample.RandomValue);
        }
    }
}
