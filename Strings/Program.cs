namespace Strings
{
    internal class Program
    {
        #region Capitalise

        //static string Capitalise(string s)
        //{


        //    string[] words = s.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        //    }

        //    return String.Join(" ", words);
        //}

        #endregion

        #region cleaning

        //static string cleaning (string text)
        //{
        //    string result = "";

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (char.IsLetterOrDigit(text[i]) || char.IsWhiteSpace(text[i]) )
        //        {
        //            result += text[i];
        //        }
        //    }

        //    return result;
        //}

        #endregion


        #region com-la bitib bitmediyini yoxlamaq
        static bool EndsWithCom (string input)
        {
            return input.EndsWith(".com");
        }
        #endregion
        static void Main(string[] args)
        {
            #region Capitalise
            //Console.Write("Setri daxil edin: ");
            //string s = Console.ReadLine();

            //Console.WriteLine("Yeni setir: ");
            //Console.WriteLine(Capitalise(s));
            #endregion

            #region cleaning
            //Console.Write("Setri daxil edin: ");
            //String s1 = Console.ReadLine();

            //Console.WriteLine("Yeni setir: ");
            //Console.WriteLine(cleaning(s1));
            #endregion

            #region com-la bitib bitmediyini yoxlamaq
            Console.Write("Setri daxil edin: ");
            string s = Console.ReadLine();

            Console.WriteLine(".com-la bitirmi? ");
            Console.WriteLine(EndsWithCom(s));
            #endregion
        }
    }
}
