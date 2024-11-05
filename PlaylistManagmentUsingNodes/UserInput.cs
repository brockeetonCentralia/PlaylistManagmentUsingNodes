using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistManagmentUsingNodes
{
    public class UserInput
    {
        static void userInput()
        {
            while (true)
            {
                Console.WriteLine("Enter song Title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Enter your chosen song's Artist: ");
                string artist = Console.ReadLine();

                Console.WriteLine("Enter the duration of your chosen song using 0.00 format: ");
                string duration = Console.ReadLine(); 
                
            }
        }
    }
}
