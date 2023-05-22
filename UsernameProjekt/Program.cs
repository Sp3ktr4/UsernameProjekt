using System;
using System.Text.RegularExpressions;
class Program 
{
    static void Main(string[] args) 
    {
        while (true)
        {
            Console.Write("Skriv in ditt username: ");
            string username = Console.ReadLine();

            if (username.Length < 2 || username.Length > 20) 
            {
                Console.WriteLine("Username får endast vara mellan 2 och 20 bokstäver långt.");
            }

            else if (!Regex.IsMatch(username, "^[a-zA-Z]+$"))
            {
                Console.WriteLine("Username får endast innehålla bokstäver.");
            }

            else 
            {
                Console.WriteLine("Username är godkänt.");
                break;
            }
        }
        Console.ReadLine();
    }
}
