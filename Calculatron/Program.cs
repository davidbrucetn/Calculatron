using Calculatron.UserInterfaceManagers;
using System;

namespace Calculatron
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterfaceManager ui = new MainMenu();

            Console.Clear();
            Console.WriteLine();

            while (ui != null) {
                ui = ui.Execute();
            };

            
        }
    }
}
