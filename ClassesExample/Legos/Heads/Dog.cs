using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    class Dog: Head
    {
        //Properties
        //Fields
        //Constructor
        //Methods
        public override string Talk() // need VIRTUAL on the base Talk
        {
            return "Bark! I'm a dog head.";
        }

        public string Lick()
        {
            return "Tastes like human.";
        }
    }

}
