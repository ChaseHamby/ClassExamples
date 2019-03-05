using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    abstract class Head //abstract is a class that can be inherited but cannot be instantiated
    {
        public HairLength HairLength { get; protected set; }
        public Colors Color { get; protected set; }
        public string EarSize { get; protected set; }

        public virtual string Talk() // need virtual so you can override other Talk methods
        {
            return "I'm a talking head.";
        }
    }
}
