using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Legs
{
    class RobotLegs : LegsBase
    {
        public RobotLegs()
        {
            Covering = "Metal";
            NumberOfLegs = 3;
            Speed = 4;
            _musicGenre = "Robo Boogie";
            Shoes = "No shoes";
            Size = Size.Giant;
        }

        public override void Dance()
        {
            Console.WriteLine($"The robot legs dance the robot for the rest of time.");
        }

    }
}
