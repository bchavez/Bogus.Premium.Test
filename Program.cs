using System;
using Bogus.Healthcare;
using Newtonsoft.Json;
using static System.Console;

namespace Bogus.Premium.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello Bogus Premium!");

            var userFaker = new Faker<User>()
               .RuleFor(u => u.FirstName, f => f.Person.FirstName)
               .RuleFor(u => u.PainArea, f => f.Human().BodyPartInternal());

            var user = userFaker.Generate();

            var json = JsonConvert.SerializeObject(user);
            WriteLine(json);
        }
    }

    public class User
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public int Age { get; set; }
       public string PainArea { get; set; }
    }
}
