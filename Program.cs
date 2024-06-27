using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        DrawBar(3, 15, colorOfActivBar: ConsoleColor.Red, posCursorY: 1);
        DrawBar(8, 15, colorOfActivBar: ConsoleColor.Green, posCursorY: 3);
    }

    static void DrawBar(int value, int maxValue, char activBar = '#', char pasivBar = '_', ConsoleColor colorOfActivBar = ConsoleColor.Green, int posCursorX = 0, int posCursorY = 0)
    {
        Console.SetCursorPosition(posCursorX, posCursorY);
        ConsoleColor memoryOfColor = Console.BackgroundColor;
        Console.BackgroundColor = colorOfActivBar;
        Console.Write('[');

        for (int i = 0; i < value; i++)
            Console.Write(activBar);

        Console.BackgroundColor = memoryOfColor;

        for (int i = value; i < maxValue; i++)
            Console.Write(pasivBar);

        Console.Write(']');
        Console.WriteLine();
    }
}