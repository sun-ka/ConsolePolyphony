using System;
using System.Threading;

namespace ConsolePolyphony
{
    class Program
    {
        public const int StandardPitch = 440;
        public const int Do = 440;  // c
        public const int Re = 494;  // d
        public const int Mi = 523;  // e
        public const int Fa = 587;  // f
        public const int Sol = 659; // g
        public const int La = 698;  // a
        public const int Si = 784;  // h
        static void Main(string[] args)
        {
            StarWars();
            Console.WriteLine(CalculateFrequency());
            Console.ReadKey();
        }

        private static void StarWars()
        {
            Console.Beep(Sol, 600);
            Console.Beep(Sol, 600);
            Console.Beep(Sol, 600);
            Console.Beep(Mi, 700);
            Console.Beep(Si, 500);
            Console.Beep(Sol, 500);
            Console.Beep(Mi, 600);
            Console.Beep(Si, 400);
            Console.Beep(Sol, 1000);
        }

        static void MusicalScale()
        {
            int duration = 500;
            Console.Beep(Do, duration);
            Console.Beep(Re, duration);
            Console.Beep(Mi, duration);
            Console.Beep(Fa, duration);
            Console.Beep(Sol, duration);
            Console.Beep(La, duration);
            Console.Beep(Si, duration);
        }

        static int CalculateFrequency() 
        {
            double n = 2; // n is the number of semitones(half steps) from the standard pitch
            var frequency = StandardPitch * Math.Pow(2, n/12);
            return (int)frequency;
        }
    }
}
