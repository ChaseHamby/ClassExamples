using ClassesExample.Legos.Heads;
using ClassesExample.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Legos
{
    class Minifigure
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }
        //Legs

        public Minifigure(Head head, Torso body)
        {
            Head = head;
            Body = body;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {
            Body.Wave();
            Head.Talk();
        }
    }
}
