namespace Methods_and_Overloading
{
    class Program
    {
        #region main
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n====== Menu ======");
                Console.WriteLine("1. Eded 3 ve 7'ye bolunurmu?");
                Console.WriteLine("2. Iki cut ededin cemi");
                Console.WriteLine("3. n ve m araligindaki tek ededlerin cemi");
                Console.WriteLine("4. Arraydaki tek ededlerin cemi");
                Console.WriteLine("5. Arraydaki cut ededlerin cemi");
                Console.WriteLine("6. Eded sade ya murekkebdir?");
                Console.WriteLine("0. Cixis");

                Console.Write("Seciminizi edin: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bolunur();
                        break;
                    case 2:
                        sum();
                        break;
                    case 3:
                        sum_in_between_two_numbers();
                        break;
                    case 4:
                        sumOddInArray();
                        break;
                    case 5:
                        sumEvenInArray();
                        break;
                    case 6:
                        checkPrimeNumber();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Movcud olmayan secim etdiniz!");
                        break;
                }
            }
        }
        #endregion

        #region bolunur
        static void bolunur()
        {

            Console.Write("3-e ve 7-e bolunub-bolunmemesini yoxlamaq ucun ededi daxil edin: ");

            int n = Convert.ToInt32(Console.ReadLine());


            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Bolunur.");
            }
            else
            {
                Console.WriteLine("Bolunmur.");
            }
        }
        #endregion

        #region sum

        static void sum()
        {

            Console.WriteLine("n ve m ededlerini daxil et: ");


            int sum = 0;

            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0 && m % 2 == 0)
            {
                sum = n + m;

                Console.WriteLine("Ededlerin cemi " + sum);
            }
            else
            {
                Console.WriteLine("Ededlerden biri ve ya her iki eded cut deyil.");
            }

        }
        #endregion

        #region sum_in_range
        static void sum_in_between_two_numbers()
        {

            Console.WriteLine("n ve m ededlerini daxil et (n < m): ");

            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;



            if (n <= m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                if (sum == 0)
                {
                    Console.WriteLine("Araliqda hec bir tek eded yoxdur.");
                }
                else
                {
                    Console.WriteLine("Araliqda tek ededlerin cemi: " + sum);
                }
            }
            else
            {
                Console.WriteLine("n ededi m ededinden kicik olmalidir.");
            }
        }
        #endregion



        #region sumOdd
        static void sumOddInArray()
        {
            Console.WriteLine("Arrayin element sayini daxil edin: ");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i + 1}-ci elementi daxil edin: ");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            bool isOdd = false;

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                    isOdd = true;
                }

            }

            if (isOdd)
            {
                Console.WriteLine("Arrayda tek ededlerin cemi: " + sum);

            }

            else
            {
                Console.WriteLine("Arrayda hec bir tek eded yoxdur.");
            }
        }

        #endregion

        #region sumEven

        static void sumEvenInArray()
        {
            Console.WriteLine("Arrayin element sayini daxil edin: ");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i + 1}-ci elementi daxil edin: ");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            bool isEven = false;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    isEven = true;
                }
            }

            if (isEven)
            {
                Console.WriteLine("Arrayda cut ededlerin cemi: " + sum);

            }

            else
            {
                Console.WriteLine("Arrayda hec bir cut eded yoxdur.");
            }
        }
        #endregion


        #region isPrime
        static void checkPrimeNumber()
        {
            Console.WriteLine("Ededi daxil edin: ");

            int n = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (n == 0 || n == 1)
            {
                Console.WriteLine(n + " ne sade, ne de murekkebdir.");
            }
            else if (n < 0)
            {
                Console.WriteLine("Menfi ededlerde sade eded olmur.");
            }
            else
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime)
                {
                    Console.WriteLine(n + " ededi sade ededdir.");
                }
                else
                {
                    Console.WriteLine(n + " ededi murekkeb ededdir.");
                }
            }
        }
        #endregion
    }
}
