using ClassesExample.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Sex sex, Colors color)
            : base(numberOfArms, sex, color, "OMG, so fit.")
        {
        }

        public void Crunch(int howManyCrunches)
        {
            FitnessOfAbdomen = FitnessOfAbdomen + " Even more fit.";
            Console.WriteLine($"I just did {howManyCrunches}, brah. CROSSFIT!");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯");
        }
    }
}
