using ClassesExample.Legos.Heads;
using ClassesExample.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos
{
    class Minifigure
    {
        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public Legs.Legs Legs { get; set; }

        public Minifigure(string name, Head head, Torso body, Legs.Legs legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {
            Legs.Jump();
            Body.Wave();
            Head.Talk();
        }
    }
}
