using System;

namespace lab1
{
    public class PersonType
    {
        // Constants
        public string ChangeColor() // this stays constant throughout 
        {
            return favoriteColour = "white"; // default color
        }

        // Properties
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        // Constructors
        public PersonType(int PersonId, string FirstName, string LastName, string FavouriteColour, int Age, bool IsWorking)
        {
            personId = PersonId;
            firstName = FirstName;
            lastName = LastName;
            favoriteColour = FavouriteColour;
            age = Age;
            isWorking = IsWorking;
        }

        // Public Methods
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}:{firstName} {lastName}'s favourite color is {favoriteColour}");
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}";
        }
    }
}
