using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace ProgrammingII_CardGames_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Crazy Cool Card Games";
            Application application = new Application();
            application.Menu();
        }
    }
}
