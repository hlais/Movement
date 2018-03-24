using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement
{
    class Program
    {
        static void Main(string[] args)
        {
            int yCordinate = 30;
            int xCordinate = 30;
            ConsoleKeyInfo inputPress;
            
            do
            {
                inputPress = Console.ReadKey();
                Console.Clear();

                switch (inputPress.Key)
                {

                    case ConsoleKey.LeftArrow:
                        xCordinate--;
                        Console.SetCursorPosition(xCordinate, yCordinate);

                        Console.WriteLine("X");
                        break;
                    case ConsoleKey.UpArrow:
                        yCordinate--;
                        Console.SetCursorPosition(xCordinate, yCordinate);
                        Console.WriteLine("X");
                        break;
                    case ConsoleKey.RightArrow:
                        xCordinate++;
                        Console.SetCursorPosition(xCordinate, yCordinate);

                        Console.WriteLine("X");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xCordinate, yCordinate);
                        yCordinate++;
                        Console.WriteLine("X");
                        break;

                    default:
                        break;
                }
            }
            while (true);
            
        }
    }
}
