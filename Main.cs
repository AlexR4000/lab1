using System;
using System.Linq;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create PersonType objects
            PersonType person1 = new PersonType(1, "Ian", "Brooks", "White", 32, true);
            PersonType person2 = new PersonType(2, "Gina", "James", "Green", 22, true);
            PersonType person3 = new PersonType(3, "Mike", "Briscoe", "Blue", 45, true);
            PersonType person4 = new PersonType(4, "Mary", "Beals", "Yellow", 28, true);

            // Display specific person details
            Console.WriteLine($"{person2.personId}: {person2.firstName} {person2.lastName}’s favorite colour is {person2.favoriteColour}");
            Console.WriteLine(person3);

            // Display specific person's favorite color and age in 10 years
            Console.WriteLine($"{person1.personId}: {person1.firstName} {person1.lastName}’s favorite colour is: {person1.favoriteColour}");
            Console.WriteLine($"{person4.firstName} {person4.lastName}’s Age in 10 years is: {person4.GetAgeInTenYears()}");

            // Create relationships
            RelationType relation1 = new RelationType(RelationType.RelationshipType.sister);
            RelationType relation2 = new RelationType(RelationType.RelationshipType.brother);

            Console.WriteLine($"Relationship between {person2.firstName} and {person4.firstName} is: Sisterhood");
            Console.WriteLine($"Relationship between {person1.firstName} and {person3.firstName} is: Brotherhood");

            // Calculate and display the average age
            var people = new[] { person1, person2, person3, person4 };
            double averageAge = people.Average(p => p.age);
            Console.WriteLine($"Average age is: {averageAge}");

            // Find the youngest and oldest persons
            PersonType youngestPerson = people.OrderBy(p => p.age).First();
            PersonType oldestPerson = people.OrderByDescending(p => p.age).First();

            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName}");

            // Display details of all people
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            // Prevent console from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
