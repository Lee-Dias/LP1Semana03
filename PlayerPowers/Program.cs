using System;
using System.Diagnostics;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("How many players will play?");
            string jogadores = Console.ReadLine();
            int n = int.Parse(jogadores);
            Powers[] PlayerPowers = new Powers[n];
            for (int p = 0; p < PlayerPowers.Length; p++){
                PlayerPowers[p] = 0;
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
                            PlayerPowers[p] ^= Powers.Fly;
                            break;
                        case '2':
                            PlayerPowers[p] ^= Powers.XRayVision;
                            break;
                        case '3':
                            PlayerPowers[p] ^= Powers.SuperStrength;
                            break;
                        default:
                            break;
                    }
                }

            }

            for (int k = 0; k < PlayerPowers.Length ; k++){
                Console.WriteLine($"Player {k} Powers: {PlayerPowers[k]} ");
            }
        }
    }
}
