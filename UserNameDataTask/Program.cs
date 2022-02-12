using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnime:");
            string userName = Console.ReadLine();

            Console.WriteLine("sisesta number 1-3");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    NameReverse(userName);
                    break;
                case 3:
                    NameLenght(userName);
                    break;
                case 2:
                    NameFirstLetter(userName);
                    break;
                default:
                    Console.WriteLine("Sisestasid vale numbri.");
                    break;
            }

        }
        public static void NameReverse(string userName)
        {
            char[] charArray = userName.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        public static void NameLenght(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
        public static void NameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
    }
}