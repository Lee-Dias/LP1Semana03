using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Powers PlayerPowers = 0;
            Console.WriteLine("How many players will play?");
            string jogadores = Console.ReadLine();
            int n = int.Parse(jogadores);
            int[] players = new int[n];
            foreach (int p in players ){
                Console.WriteLine("What are your powers? u can combine!!");
                Console.WriteLine("Type F for Fly");
                Console.WriteLine("Type X for XRayVision");
                Console.WriteLine("Type S for SuperStrength");
                string powers = Console.ReadLine();

            }
        }
    }
}
