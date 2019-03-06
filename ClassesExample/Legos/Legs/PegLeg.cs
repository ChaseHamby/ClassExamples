using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Legs
{
    class PegLeg : Legs
    {
        public PegLeg(Length legLength) 
            : base(legLength, Colors.Tan)
        {
        }

        public override void Jump()
        {
            Console.WriteLine($"The { (Hairy ? "hairy " : "") } peg legs don't jump");
        }

        
    }
}
