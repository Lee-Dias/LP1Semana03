﻿using System;

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


            Console.WriteLine("Hello, World!");
        }
    }
}
