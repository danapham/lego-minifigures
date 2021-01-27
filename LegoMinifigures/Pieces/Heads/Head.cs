using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Heads
{
    //Base Class
    //Abstract classes can't be instantiated
    //They can only be inherited from
    abstract class Head
    {
        public Color EyeColor { get; set; }
        public string Eyewear { get; set; }

        //no implementation, only allowed on abstract classes
        //no ideas or opinions on how inheriting classes implement the method/behavior
        public abstract void Greet();

        public void Talk(string wordsToSay)
        {
            Greet();
            Console.WriteLine($"The {GetType().Name} says {wordsToSay}");
        }
    }
}
