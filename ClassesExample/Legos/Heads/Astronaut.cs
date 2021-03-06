﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Heads
{
    class Astronaut : Head
    {
        public List<string> Accessories { get; set; }

        public override string Talk() // method signature
        {
            return $"Houston, we have a problem. I have {HairLength} " +
                $"long hair and I'm {Color} and my ears are {EarSize}";
        }
    }
}
