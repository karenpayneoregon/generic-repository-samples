using Bogus;
using EntityFrameworkCoreBulkInsertsApp.Models;

using static Bogus.Randomizer;

namespace EntityFrameworkCoreBulkInsertsApp.Classes;
public class BogusOperations
{
    /// <summary>
    /// Create a list of Customer
    /// </summary>
    /// <param name="count">How many items to create</param>
    /// <param name="random">Set up for the same data each time or not</param>
    /// <returns>List of Customer</returns>
    public static List<Customer> CreateCustomers(int count, bool random = false)
    {
        if (!random)
        {
            Seed = new Random(338);
        }

        var faker = new Faker<Customer>()
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.BirthDay, f => 
                f.Date.BetweenDateOnly(new DateOnly(1950, 1, 1), new DateOnly(2010, 1, 1)))
            .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
            .RuleFor(c => c.Gender, f => f.PickRandom<Gender>());


        return faker.Generate(count);

    }
}