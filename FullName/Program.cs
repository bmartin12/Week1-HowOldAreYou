using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest kasutaja eesnime
            //programm küsib kasutaja käest kasutaja perekonnanime
            //programm tervitab kasutajat kasutades neid andmeid

            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Hello, {FirstName} {LastName}");



        }
    }
}
