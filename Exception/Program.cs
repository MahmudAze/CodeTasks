using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Istifadeci adi daxil edin: ");
                string username = Console.ReadLine();

                Console.Write("Parolu daxil edin: ");
                string password = Console.ReadLine();

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    throw new Exception("Istifadeci adi ve ya parol bos ola bilmez!");
                }

                string correctUsername = "admin";
                string correctPassword = "admin123";

                if (username != correctUsername || password != correctPassword)
                {
                    throw new InvalidCredentialsException("Ugursuz giris");
                }
                else
                {
                    Console.WriteLine("Ugurlu giris");
                }


            }
            catch (EmptyFieldException ex)
            {
                Console.WriteLine($"Xeta: {ex.Message}");
            }
            catch (InvalidCredentialsException ex)
            {
                Console.WriteLine($"Ugursuz cehdi: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bilinmeyen xeta: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Proses bitdi");
            }
            
        }
    }
}
