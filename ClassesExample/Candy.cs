using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample
{
    class Candy
    {
        // Properties
        public string Flavor { get; } // If property is public - the getter/setter are public unless specified
        public int Rating { get; private set; }
        public string Review { get; private set; }
        public string Name { get; } 
        public CandyType Type { get; }


        // Fields
        const int MinRatingValue = 1; // const fields must be upper case // implicitly private
        const int MaxRatingValue = 10;

        // Constructor
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }
        
        // Methods
        public void SetRating(int userRating) // accessability / return Type / name / parameter list
        {
            if(userRating >= MinRatingValue && userRating <= MaxRatingValue) // between 1-10
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue} - {MaxRatingValue}.");
            }
        }

        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}.";
        }
    }

    enum CandyType // enum defined by list of options that can be stored as a property
    {
        Chocolate,
        HardCandy,
        Caramel,
        Sour,
        Stretchy,
        Nut
    }
}
