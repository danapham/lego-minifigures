using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Legs
{
    class LegsBase
    {
        public string Covering { get; set; }
        public Size Size { get; set; }
        public int Speed { get; set; }
        public string Shoes { get; set; }
        public int NumberOfLegs { get; set; }

        protected string _musicGenre;


        public LegsBase()
        {
            NumberOfLegs = 2;
            Size = Size.Adult;
            Covering = "Pants";
            Speed = 1;
            _musicGenre = "Waltz";
        }

        public virtual void Dance()
        {
            var danceSpeed = Speed > 5 ? "Fast" : "Slow";

            Console.WriteLine($"The {GetType().Name} {Size} legs danced {danceSpeed} to {_musicGenre}.");
        }

        public void Walk()
        {
            Console.WriteLine($"The {GetType().Name} {Size} legs walked {Speed} steps forward.");
        }
    }
}
