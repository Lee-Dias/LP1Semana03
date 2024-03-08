using System;
using System.Diagnostics;

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
            foreach (int p in players){
                PlayerPowers = 0;
                Console.WriteLine("What are your powers? u can combine!!");
                Console.WriteLine("Type 1 for Fly");
                Console.WriteLine("Type 2 for XRayVision");
                Console.WriteLine("Type 3 for SuperStrength");
                string powers = Console.ReadLine();
                foreach (char c in powers)
                {
                    switch (c)
                    {
                        case '1':
                            PlayerPowers ^= Powers.Fly;
                            break;
                        case '2':
                            PlayerPowers ^= Powers.XRayVision;
                            break;
                        case '3':
                            PlayerPowers ^= Powers.SuperStrength;
                            break;
                        default:
                            break;
                    }
                }

            }

            foreach(int k in players){
                Console.WriteLine(PlayerPowers);
            }
        }
    }
}
