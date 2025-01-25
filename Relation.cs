using System;

namespace lab1
{
    public class RelationType
    {
        // Enum for relationship types
        public enum RelationshipType { sister, brother, father, mother }

        // Property to hold the relationship type
        public RelationshipType Relationship { get; set; }

        // Constructor
        public RelationType(RelationshipType relationship)
        {
            Relationship = relationship;
        }

        // Public method to show the relationship
        public string ShowRelationship(PersonType person1, PersonType person2)
        {
            return $"The relationship between {person1.firstName} and {person2.firstName} is {Relationship}.";
        }
    }
}
