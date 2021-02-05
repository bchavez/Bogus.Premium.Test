using System;
using static System.Console;

namespace Bogus.Premium.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello Bogus!");

            var userFaker = new Faker<User>();
        }
    }

    public class User
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public int Age { get; set; }
    }
}
