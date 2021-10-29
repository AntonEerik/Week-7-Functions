using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta number 1-3-ni:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            
            GetUserNameData(userName, userNumber);
        }
        public static void GetUserNameData(string userName, int userNumber)
        {
            if (userNumber == 1)
            {
                for (int i = userName.Length-1; i >= 0; i--)
                {
                    Console.Write(userName[i]);
                }
            }
            else if (userNumber == 2)
            {
                Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk."); 
            }
        }
    }
}