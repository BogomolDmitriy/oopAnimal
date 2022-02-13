using System;

namespace Library
{
    public abstract class Animal
    {
        public abstract string SaySound();

        public double Weigtht { get; protected set; }

        public virtual string getColor()
        {
            return "Black";
        }

    }
}
