using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammingII_CardGames_Project1
{
    public class Utility
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);

        }

        public string ConvertTextToLowerCase(string message) => message.ToLower();
        public static string getInputFromPlayer() => Console.ReadLine();

        public static void Pause()
        {
            Print("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
