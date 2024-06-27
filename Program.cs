using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        DrawBar(30, colorOfActivBar: ConsoleColor.Red, posCursorY: 1);
        DrawBar(50, colorOfActivBar: ConsoleColor.Green, posCursorY: 3);
    }

    static void DrawBar(int value, int maxValue = 10, char activBar = '#', char pasivBar = '_', ConsoleColor colorOfActivBar = ConsoleColor.Green, int posCursorX = 0, int posCursorY = 0)
    {
        Console.SetCursorPosition(posCursorX, posCursorY);
        ConsoleColor memoryOfColor = Console.BackgroundColor;
        Console.BackgroundColor = colorOfActivBar;
        Console.Write('[');

        float persents = ((float)value / 100.0f);
        value = (int)(persents * maxValue);

        if (value > maxValue)
            value = maxValue;

        for (int i = 0; i < maxValue; i++)
        {
            if (i < value)
            {
                Console.Write(activBar);
            }
            else
            {
                Console.BackgroundColor = memoryOfColor;
                Console.Write(pasivBar);
            }
        }

        Console.Write(']');
        Console.WriteLine();
    }
}