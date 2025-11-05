namespace ConsoleApp1
{
    internal class Program
    {
        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }

        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");

            int i = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("i deyisenin evvelki qiymeti:" + i.ToString());
            string test = GetNextName(ref i);
            Console.WriteLine("i deysienin sonraki qiymeti:" + i.ToString());
        }
    }
}
