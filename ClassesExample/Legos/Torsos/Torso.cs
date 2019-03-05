using ClassesExample.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Torsos
{
    abstract class Torso
    {
        public int NumberOfArms { get; protected set; }
        public string FitnessOfAbdomen { get; protected set; } // protected means me or someone who inherits from me can access and change this. Everyone else is read only
        public Sex Sex { get; protected set; }
        public Colors Color { get; protected set; }

        protected Torso(int numberOfArms, Sex sex, Colors color, string fitnessOfAbdomen) // any constructor inside an abstract class is protected
        {
            NumberOfArms = numberOfArms;
            Sex = sex;
            Color = color;
            FitnessOfAbdomen = fitnessOfAbdomen;
        }

        public virtual void Wave()
        {
            Console.WriteLine("Waves hello 0/");
        }
    }

    internal enum Sex
    {
        Male,
        Female,
        Other,
        Shrug
    }
}
