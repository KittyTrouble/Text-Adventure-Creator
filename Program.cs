using System;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Room testRoom = new Room("Test room", "You are in an unfinished room.");
                Console.WriteLine(testRoom);
                Console.ReadLine();
            }
        }
    }
}   
