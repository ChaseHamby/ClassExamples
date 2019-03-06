using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos.Legs
{
    abstract class Legs
    {

        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        protected Legs(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("Weeeeee");
        }

        public void Kick(Minifigure personToKick)
        {
            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. Ha Ha Ha.");
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} took a few steps");
        }

    }

    internal enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}
