using System;

namespace Tuples
{
    class Program
    {
        static (string FirstName, string LastName, int Year) GetAnonymous()
        {
            return ("Mary","Shelley",1797);
        }

        static void Main()
        {
            //string val = "25";

            //if (int.TryParse(val, out int _))
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Invalid");


            //var (_ , surname, _) = GetAnonymous();


            //Console.WriteLine(surname);

             BookExamples.ProcessBooks();
        }
    }
}
