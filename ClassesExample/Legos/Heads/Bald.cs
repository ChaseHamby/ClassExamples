using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    class Bald : Head
    {
        //Properties
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }
        //Fields
        //Constructor
        //Methods

        public void Cut(HairLength newLength)
        {
            HairLength = newLength;
        }

        public override string Talk()
        {
            return "I pity the fool!";
        }
    }

    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }

    internal enum Colors
    {
        Yellow,
        Red,
        Freckles,
        Tan
    }
}

