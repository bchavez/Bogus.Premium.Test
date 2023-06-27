using System;
using Bogus.Healthcare;
using Newtonsoft.Json;
using static System.Console;

namespace Bogus.Premium.Test
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Hello Bogus Premium!");

            var userFaker = new Faker<User>()
               .RuleFor(u => u.FirstName, f => f.Person.FirstName)
               .RuleFor(u => u.PainArea, f => f.Human().BodyPartInternal())
               .RuleFor(u => u.LastName, f => f.Person.LastName)
               .RuleFor(u => u.Age, f => f.Random.Int(1, 100));

            for (var i = 0; i < 200; i++)
            {
                var user = userFaker.Generate();

                var json = JsonConvert.SerializeObject(user);
                WriteLine(json);
            }
        }
    }
}
