using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
    class Program
    {   
        static void Main(string[] args)
        {

            Perks PlayerPerks = 0;
        foreach (char c in args[0])
        {
            switch (c)
            {
                case 'w':
                    PlayerPerks ^= Perks.WaterBreathing;
                    break;
                case 'a':
                    PlayerPerks ^= Perks.AutoHeal;
                    break;
                case 's':
                    PlayerPerks ^= Perks.Stealth;
                    break;
                case 'd':
                    PlayerPerks ^= Perks.DoubleJump;
                    break;
                default:
                    Console.WriteLine("Unknown perk!");
                    return;
            }
        }
    }
}
}
