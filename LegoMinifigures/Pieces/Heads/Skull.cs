using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Heads
{
    class Skull : Head
    {
        public Condition Condition { get; set; }
        public Color Color { get; set; }

        public void Wail()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming {Color} skull with {EyeColor} eyes wails angrily.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull wails mournfully because it is dead and {Condition} not on fire.");
            }
        }

        public override void Greet()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming {Color} skull with {EyeColor} eyes smoulders in your direction.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull is dead and can't greet you.");
            }
        }

    }
}
