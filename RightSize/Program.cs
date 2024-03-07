using System;
using System.Diagnostics;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string Str in args){

                if(Str.Length >3 & Str.Length <6){
                    Console.WriteLine(Str);
                }
                if(Str.Length>6){
                    return;
                }

            }

        }
    }
}

