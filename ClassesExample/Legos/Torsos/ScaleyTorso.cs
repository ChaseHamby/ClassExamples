using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Torsos
{
    class ScaleyTorso : Torso
    {
        public ScaleyTorso() 
            : base(4, Sex.Other, Colors.Red, "Hard as a rock")
        {
        }

        public override void Wave()
        {
            Console.WriteLine(@"Fragile waving \O/"); // @ sign makes it a string literal and writes out the line exactly
        }
    }
}
