namespace Static__Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quvveti daxil edin: ");
            int p = Convert.ToInt32(Console.ReadLine());

            int res = Extention.Power(n, p);

            Console.WriteLine("Netice: " + res);
        }
    }
}
