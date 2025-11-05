using System.Net.Mail;

namespace Inheritance__Access_Modifiers__Encapsulation
{
    #region faktorial - Task 2

    //class Faktorial
    //{
    //    private int faktorial = 1;

    //    public void GetData(int number)
    //    {
    //        if (number < 0)
    //        {
    //            Console.WriteLine("faktorial ucun menfi eded ola bilmez");
    //        }
    //        else if (number == 0 || number == 1)
    //        {
    //            Console.WriteLine("Faktorial 1-dir");
    //        }
    //        else
    //        {
    //            for (int i = 1; i <= number; i++)
    //            {
    //                faktorial *= i;
    //            }

    //            Console.WriteLine("Faktorial: " + faktorial);
    //        }

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("faktorial ucun ededi daxil edin: ");
    //        int n = Convert.ToInt32(Console.ReadLine());

    //        Faktorial f = new Faktorial();

    //        f.GetData(n);
    //    }
    //}

    #endregion

    #region Login Verification - Task 3
    //class VeriyLogin
    //{
    //    private string mail = "emil@code.edu.az";
    //    private string password = "12345";

    //    public void GetVerified(string user, string pass)
    //    {
    //        if (user == mail && pass == password)
    //        {
    //            Console.WriteLine("Girish olundu");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Mail ve yaxud password sehvdir");
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Email: ");
    //        string email = Console.ReadLine();

    //        Console.Write("Parol: ");
    //        string parol = Console.ReadLine();

    //        VeriyLogin veriyLogin = new VeriyLogin();

    //        veriyLogin.GetVerified(email, parol);
    //    }
    //}

    #endregion
}
