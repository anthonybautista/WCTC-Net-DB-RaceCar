using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Vespa : RaceCar
    {
        public Vespa()
        {
            Name = "Vespa";
            TopSpeed = 55;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts its little engine! Beep Beep!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} rolls to a stop!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} turns off its little engine and puts down the kickstand.");
        }
    }
}