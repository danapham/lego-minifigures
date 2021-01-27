using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Torsos
{
    class PirateTorso : Torso
    {
        //can't be set outside of the constructor
        public bool HasHook { get; }

        public PirateTorso(bool hasHook)
        {
            Accessory = "Parrot";
            HasHook = hasHook;
        }

        public override void Wave()
        {
            if (HasHook)
            {
                Console.WriteLine("The pirate torso beckons menacingly with their hook...");
            }
            else
            {
                //use the default wave
                base.Wave();
                //Console.WriteLine($"The pirate torso gives you the finger.");
            }
        }
    }
}
