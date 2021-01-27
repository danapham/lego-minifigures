using System;
using LegoMinifigures.Pieces;
using LegoMinifigures.Pieces.Heads;
using LegoMinifigures.Pieces.Legs;
using LegoMinifigures.Pieces.Torsos;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.Eyewear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Female;

            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            var skull = new Skull
            {
                Color = Color.Red,
                Condition = Condition.OnFire,
                EyeColor = Color.Green,
                Eyewear = "Aviators"
            };

            var heads = new Head[] {coolHead, nerdHead, skull};

            foreach (var head in heads)
            {
                head.Greet();
                head.Talk("Stuff");
            }

            var pirateWithHook = new PirateTorso(true) { Clothing = Clothing.SmokingJacket };
            var pirateWithoutHook = new PirateTorso(false) { Clothing = Clothing.Raincoat };

            pirateWithHook.Wave();
            pirateWithoutHook.Wave();

            var torso = new Torso { Clothing = Clothing.Hoodie, Color = Color.Green, NumberOfArms = 0 };

            var skeletonTorso = new SkeletonTorso(false, Condition.OnFire);

            var policeTorso = new PoliceOfficerTorso();

            var torsos = new Torso[] { pirateWithoutHook, pirateWithHook, skeletonTorso, torso, policeTorso };

            foreach (var body in torsos)
            {
                body.Wave();
            }

            var legs = new DiscoLegs();

            var skullPoliceSpider = new Minifigure(skull, policeTorso, new SpiderLegs(), "Weird Dude");
            skullPoliceSpider.MeetSomeone();
        }
    }
}
