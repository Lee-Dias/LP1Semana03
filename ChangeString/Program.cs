using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tell me something");
            string str = Console.ReadLine();
            Console.WriteLine("give me one character");
            string Scar = Console.ReadLine();
            char car = char.Parse(Scar);
            char write;
            string newstr = "";
            for (int i = 0; i <  str.Length; i++){
                write = str[i];
                if (str[i] == car){
                    write = 'X';
                }
                newstr += write;
            }
            Console.WriteLine(newstr);

        }
    }
}
