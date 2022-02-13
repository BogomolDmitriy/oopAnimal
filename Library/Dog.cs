using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Dog : Animal
    {
        public override string SaySound()
        {
            return "Wof";
        }

        public override string getColor()
        {
            return "Blue";
        }
    }
}
